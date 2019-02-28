using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using OfficeOpenXml;
using ToolConvertImageToExcel.Controls;
using ToolConvertImageToExcel.Models;
using ToolConvertImageToExcel.Services;


namespace ToolConvertImageToExcel
{
    public partial class Main : MetroForm
    {
        public Point _startPoint;

        public Point _endPoint;
        Rectangle _rectCropArea;
        public bool _mouseClicked { get; set; }
        public string _ImagePath { get; set; }
        public string _TesseractPath { get; set; }
        public List<Rectangle> _ListPosition { get; set; }
        public List<Rectangle> _TempPosition { get; set; }

        private DocumentMangament _documentMangament;
        public Main()
        {
            InitializeComponent();
            try
            {
                splitContainer1.SplitterDistance = splitContainer1.Width / 2; // chia điều split
                superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
                superGridControl2.PrimaryGrid.ShowRowGridIndex = true;
                InitializeGrid();
                _TesseractPath = Directory.GetCurrentDirectory() + @"\tesseract";
                _ImagePath = Path.GetTempPath()+ Application.ProductName + @"\temp";
                if (Directory.Exists(_ImagePath))
                {
                    Directory.Delete(_ImagePath, true);
                }
                Directory.CreateDirectory(_ImagePath);
                
                _ListPosition = new List<Rectangle>();
                _TempPosition = new List<Rectangle>();
                superGridControl1.PrimaryGrid.Columns["CellDeleteRow"].EditorType = typeof(ButtonDeleteRow);
                _documentMangament = new DocumentMangament();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void InitializeGrid()
        {
            GridPanel panel = superGridControl2.PrimaryGrid;

            panel.NullString = null;
            panel.AllowEmptyCellSelection = true;
            panel.ShowRowGridIndex = true;
            panel.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.Select;

            panel.DefaultVisualStyles.
                CellStyles.Empty.Background = new Background(Color.White);

            // Add a column for each letter of the alphabet
            /*GridColumn colDelete = new GridColumn();

            colDelete.Width = 40;
            colDelete.EditorType = typeof(ButtonDeleteRow);
            panel.Columns.Add(colDelete);*/
            for (int i = 0; i < 26; i++)
            {
                GridColumn col = new
                    GridColumn(((char)(65 + i)).ToString());

                col.Width = 80;
                col.EditorType = typeof(GridTextBoxXEditControl);
                panel.Columns.Add(col);
            }

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImage.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseClicked = true;

            _startPoint.X = e.X;
            _startPoint.Y = e.Y;

            _endPoint.X = -1;
            _endPoint.Y = -1;

            _rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
        }
        
        private void pictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;

            _endPoint.X = -1;
            _endPoint.Y = -1;
            _startPoint.X = -1;
            _startPoint.Y = -1;

            if (_rectCropArea.Width != 0 && _rectCropArea.Height != 0)
            {
                _TempPosition.Add(_rectCropArea);
                ConvertImageToText(_rectCropArea);
            }
        }

        private void ConvertImageToText(Rectangle rectangleCrop)
        {
            var imageFileSave = _ImagePath + $"\\{DateTime.Now.Ticks}.jpg";
            var imgCrop = CropImage(rectangleCrop);
            imgCrop.Save(imageFileSave, ImageFormat.Jpeg);
            var imageFile = File.ReadAllBytes(imageFileSave);
            var text = ParseText(_TesseractPath, imageFile, "eng");

            //add to grid
            var item = new ImagePosition
            {
                ImageCrop = imageFileSave,
                ImageContent = text,
                ImageRectangle = rectangleCrop
            };
            var gridRow = new GridRow {RowHeight = 0};
            var gridCell1 = new GridCell {Value = item.ImageCrop};
            var gridCell2 = new GridCell {Value = item.ImageContent};
            var gridCell3 = new GridCell {Value = item.ImagePos};
            var gridCell4 = new GridCell {Value = "Xóa"};
            gridRow.Cells.Add(gridCell1);
            gridRow.Cells.Add(gridCell2);
            gridRow.Cells.Add(gridCell3);
            gridRow.Cells.Add(gridCell4);
            this.superGridControl1.PrimaryGrid.Rows.Add(gridRow);
        }

        private Bitmap CropImage(Rectangle rectangle)
        {
            var target = new Bitmap(rectangle.Width, rectangle.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(pictureBoxImage.Image, new Rectangle(0, 0, target.Width, target.Height), rectangle, GraphicsUnit.Pixel);
            }
            return target;
        }

        private static string ParseText(string tesseractPath, byte[] imageFile, params string[] lang)
        {
            string output = string.Empty;
            var tempOutputFile = Path.GetTempPath() + Guid.NewGuid();
            var tempImageFile = Path.GetTempFileName();

            try
            {
                File.WriteAllBytes(tempImageFile, imageFile);

                var info = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WorkingDirectory = tesseractPath,
                    FileName = "cmd.exe",
                    Arguments =$"/c tesseract.exe \"{tempImageFile}\" \"{tempOutputFile}\" -l {string.Join("+", lang)}"
                };

                // Start tesseract.
                using (var process = Process.Start(info))
                {
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {
                        // Exit code: success.
                        output = File.ReadAllText(tempOutputFile + ".txt");
                    }
                    else
                    {
                        throw new Exception("Error. Tesseract stopped with an error code = " + process.ExitCode);
                    }
                }
                   
            }
            finally
            {
                File.Delete(tempImageFile);
                File.Delete(tempOutputFile + ".txt");
            }

            output = System.Text.RegularExpressions.Regex.Replace(output, "\n+", "\n").Replace("\n", " ").Trim();
            output = System.Text.RegularExpressions.Regex.Replace(output, " +", " ");
            return output;
        }


        private void pictureBoxImage_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            if (_mouseClicked)
            {
                if (_endPoint.X != -1)
                {
                    // Display Coordinates
                    /* X1.Text = startPoint.X.ToString();
                     Y1.Text = startPoint.Y.ToString();
                     X2.Text = e.X.ToString();
                     Y2.Text = e.Y.ToString();*/
                }

                _endPoint = ptCurrent;

                if (e.X > _startPoint.X && e.Y > _startPoint.Y)
                {
                    _rectCropArea.Width = e.X - _startPoint.X;
                    _rectCropArea.Height = e.Y - _startPoint.Y;
                }
                else if (e.X < _startPoint.X && e.Y > _startPoint.Y)
                {
                    _rectCropArea.Width = _startPoint.X - e.X;
                    _rectCropArea.Height = e.Y - _startPoint.Y;
                    _rectCropArea.X = e.X;
                    _rectCropArea.Y = _startPoint.Y;
                }
                else if (e.X > _startPoint.X && e.Y < _startPoint.Y)
                {
                    _rectCropArea.Width = e.X - _startPoint.X;
                    _rectCropArea.Height = _startPoint.Y - e.Y;
                    _rectCropArea.X = _startPoint.X;
                    _rectCropArea.Y = e.Y;
                }
                else
                {
                    _rectCropArea.Width = _startPoint.X - e.X;
                    _rectCropArea.Height = _startPoint.Y - e.Y;
                    _rectCropArea.X = e.X;
                    _rectCropArea.Y = e.Y;
                }
                pictureBoxImage.Refresh();
            }
        }

        private void pictureBoxImage_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Red);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, _rectCropArea);
        }


        private void btnAddToExcel_Click(object sender, EventArgs e)
        {
            if (superGridControl1.PrimaryGrid.Rows.Count <= 0) return;
            var gridRow = new GridRow { RowHeight = 0 };
            foreach (var gridElement in superGridControl1.PrimaryGrid.Rows)
            {
                var row = (GridRow)gridElement;
                var gridCell = new GridCell { Value = row.Cells["CellImageContent"].Value };
                gridRow.Cells.Add(gridCell);
            }
            //clear bảng 1
            this.superGridControl2.PrimaryGrid.Rows.Add(gridRow);
            superGridControl1.PrimaryGrid.Rows.Clear();
            _TempPosition.Clear();

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (superGridControl2.PrimaryGrid.Rows.Count <= 0)
            {
                return;
            }
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = DateTime.Now.ToString("ddMMyyyy"),
                Title = "Save Files",
                CheckPathExists = true,
                DefaultExt = "xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var listData = new List<object[]>();
            using (var excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Data");
                var worksheet = excel.Workbook.Worksheets.FirstOrDefault();
                foreach (var gridElement in superGridControl2.PrimaryGrid.Rows)
                {
                    var row = (GridRow)gridElement;
                    var cellData = row.Cells.Select(x => x.Value).ToArray();
                    listData.Add(cellData);
                }
                worksheet.Cells[1, 1].LoadFromArrays(listData);
                excel.SaveAs(new FileInfo(saveFileDialog1.FileName));
            }
            //clear bảng 2
            superGridControl2.PrimaryGrid.Rows.Clear();
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            var documentName = string.Empty;
            if (Popup.InputBox("Lưu tọa độ tài liệu", "Đặt tên tài liệu:", ref documentName) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(documentName))
                {
                    MessageBox.Show("Chưa đặt tên tài liệu", "Thông báo");
                    return;
                }

                if (!_TempPosition.Any())
                {
                    MessageBox.Show("Không có tọa độ cần lưu", "Thông báo");
                    return;
                }

                _documentMangament.Add(documentName, _TempPosition);

                _ListPosition = new List<Rectangle>();
                _ListPosition.AddRange(_TempPosition);
                MessageBox.Show("Lưu tọa độ thành công", "Thông báo");
            }
        }

        private void btnLoadPosition_Click(object sender, EventArgs e)
        {
            if(!_ListPosition.Any()) return;
            foreach (var rectangle in _ListPosition)
            {
                ConvertImageToText(rectangle);
            }
        }
    }

}