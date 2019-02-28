using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoRowDetail : Office2007Form
    {
        #region Private data

        private Random _Rand = new Random();

        private const TextFormatFlags Tf = TextFormatFlags.EndEllipsis | TextFormatFlags.Left |
            TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;

        private string[] _Users = new string[] { 
            "Jessica Gold", "Angela Greese", 
            "Tashi Ko", "Mike Belton", "Infilta Research",
            "Bailey's OPE", "Nelson & Assoc."};

        private string[] _Messages = new string[] { 
            "Tried to add you on Facebook but was unable to.",
            "Re: Website Development.",
            "Bid Request from Bugs Media.",
            "Nokia n900 recall.",
            "Invitation for meeting.",
            "Re: Your order was received. Please allow 2 weeks for processing.",
            "Sale ends this Sunday!",
            "Please remit payment ASAP"};

        private Timer _Timer;

        #endregion

        public DemoRowDetail()
        {
            // Initialize the grid
            // and set the sample description text

            InitializeComponent();
            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoRowDetail.rtf");

            superGridControl1.PrimaryGrid.AutoExpandSetGroup = true;

            superGridControl1.DefaultVisualStyles.RowStyles.SelectedMouseOver =
                superGridControl1.BaseVisualStyles.RowStyles.Selected;

            superGridControl1.ColumnGrouped += SuperGridControl1ColumnGrouped;
            superGridControl1.RowActivated += SuperGridControl1RowActivated;

            _Timer = new Timer();

            _Timer.Interval = 1250;
            _Timer.Tick += TimerTick;
        }

        #region InitializeGrid

        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            for (int i = 0; i < 50; i++)
            {
                int n = Math.Max(_Rand.Next(-10, 40), 0);
                int m = _Rand.Next(0, 40);

                DateTime date = DateTime.Now.AddDays(-n);

                string category = (n > 30 ? "3" : n > 7 ? "2" : n > 0 ? "1" : "0");

                GridRow row = new GridRow(category,
                    _Users[m % _Users.Length], date, "", (m + 2) * 64,
                    (m % 10 == 0) ? "True" : "", _Messages[m % _Messages.Length]);

                panel.Rows.Add(row);
            }

            panel.Columns["User"].CellStyles.Default.ImageIndex = 0;
        }

        #endregion

        #region SuperGridControl1ColumnGrouped

        private void SuperGridControl1ColumnGrouped(object sender, GridColumnGroupedEventArgs e)
        {
            string s = e.GridGroup.Text;

            if (e.GridColumn.ColumnIndex == 0)
            {
                switch (s)
                {
                    case "0":
                        e.GridGroup.Text = "Today";
                        break;

                    case "1":
                        e.GridGroup.Text = "Last Week";
                        break;

                    case "2":
                        e.GridGroup.Text = "Last Month";
                        break;

                    default:
                        e.GridGroup.Text = "Older";
                        break;
                }
            }
        }

        #endregion

        #region SuperGridControl1RowGetDetailHeight

        void SuperGridControl1RowGetDetailHeight(object sender, GridGetDetailRowHeightEventArgs e)
        {
            GridRow row = e.GridRow;

            if (row != null)
            {
                string s = row.Cells["Message"].Value.ToString();

                Rectangle r = row.FirstVisibleCell.ContentBounds;
                Rectangle t = row.GetNextVisibleCell(row.FirstVisibleCell).GridColumn.Bounds;

                Size rsize = e.SizeNeeded;
                rsize.Height = 0;
                rsize.Width = (t.Right - r.X) - GetFlagsWidth(row);

                Size size = TextRenderer.MeasureText(s, SystemFonts.DefaultFont, rsize, Tf);

                e.PostDetailHeight = size.Height + 4;

                if (row.GridIndex % 4 == 0)
                    e.PreDetailHeight = 30;
            }
        }

        #endregion

        #region SuperGridControl1PostRenderRow

        void SuperGridControl1PostRenderRow(object sender, GridPostRenderRowEventArgs e)
        {
            GridRow row = e.GridRow as GridRow;

            if (row != null)
            {
                Rectangle r = row.FirstVisibleCell.ContentBounds;
                Rectangle t = row.GetNextVisibleCell(row.FirstVisibleCell).Bounds;

                r.Width = t.Right - r.X - GetFlagsWidth(row);

                r.Y = e.Bounds.Bottom - row.EffectivePostDetailRowHeight - 2;
                r.Height = row.EffectivePostDetailRowHeight;

                string s = row.Cells["Message"].Value.ToString();

                TextRenderer.DrawText(e.Graphics, s, SystemFonts.DefaultFont, r,
                                      row.IsSelected ? Color.Black : Color.Gray, Tf);

                t.Y = r.Y;

                if (row.GridIndex % 16 == 0)
                {
                    e.Graphics.DrawImage(imageList1.Images[2], new Point(t.Right - 18, t.Y));
                    e.Graphics.DrawImage(imageList1.Images[3], new Point(t.Right - 36, t.Y));
                }
                else if (row.GridIndex % 4 == 0)
                {
                    e.Graphics.DrawImage(imageList1.Images[2], new Point(t.Right - 18, t.Y));
                }
                else if (row.GridIndex % 5 == 0)
                {
                    e.Graphics.DrawImage(imageList1.Images[3], new Point(t.Right - 18, t.Y));
                }

                if (row.EffectivePreDetailRowHeight > 0)
                {
                    r.Y = e.Bounds.Y;
                    r.Height = row.EffectivePreDetailRowHeight;

                    r.Inflate(-4, -4);

                    e.Graphics.FillRectangle(Brushes.LightPink, r);
                    e.Graphics.DrawRectangle(Pens.RosyBrown, r);

                    r.Inflate(-4, -4);

                    TextRenderer.DrawText(e.Graphics, "Please follow this thread closely",
                        SystemFonts.DefaultFont, r, Color.Firebrick, Tf | TextFormatFlags.HorizontalCenter);
                }
            }
        }

        #endregion

        #region SuperGridControl1RowActivated

        void SuperGridControl1RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            GridRow row = e.NewActiveRow as GridRow;

            if (row != null)
            {
                _Timer.Stop();

                _Timer.Tag = row;
                _Timer.Start();
            }
        }

        #region TimerTick

        void TimerTick(object sender, EventArgs e)
        {
            Timer timer = (Timer) sender;

            GridRow row = timer.Tag as GridRow;

            if (row != null)
            {
                GridRow arow = superGridControl1.ActiveRow as GridRow;

                if (arow == row)
                {
                    if ("Read".Equals(row.Cells["Read"].Value) == false)
                    {
                        row.Cells["User"].CellStyles.Default.ImageIndex = 1;
                        row.Cells["Read"].Value = "Read";
                    }
                }
            }

            timer.Stop();
        }

        #endregion

        #endregion

        #region CbxGroupByDateCheckedChanged

        private void CbxGroupByDateCheckedChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            if (cbxGroupByDate.Checked == true)
                panel.SetGroup(panel.Columns["Period"]);
            else
                panel.SetGroup();

            superGridControl1.Focus();
        }

        #endregion

        #region CbxAddPreviewCheckedChanged

        private void CbxAddPreviewCheckedChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            if (cbxAddPreview.Checked == true)
            {
                panel.Columns["Message"].Visible = false;

                superGridControl1.GetDetailRowHeight += SuperGridControl1RowGetDetailHeight;
                superGridControl1.PostRenderRow += SuperGridControl1PostRenderRow;
            }
            else
            {
                panel.Columns["Message"].Visible = true;

                superGridControl1.GetDetailRowHeight -= SuperGridControl1RowGetDetailHeight;
                superGridControl1.PostRenderRow -= SuperGridControl1PostRenderRow;
            }

            panel.InvalidateLayout();

            superGridControl1.Focus();
        }

        #endregion

        #region GetFlagsWidth

        private int GetFlagsWidth(GridRow row)
        {
            if (row.GridIndex % 16 == 0)
                return (36);

            if (row.GridIndex % 4 == 0 || row.GridIndex % 5 == 0)
                return (20);

            return (0);
        }

        #endregion
    }
}