using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Newtonsoft.Json;

namespace ToolConvertImageToExcel.Services
{
    public class DocumentMangament
    {
        private string _DocumentName = Directory.GetCurrentDirectory() + @"\document.json";
        private ComboBoxEx _comboBoxEx;
        public Dictionary<string, List<Rectangle>> _Documents { get; set; } = new Dictionary<string, List<Rectangle>>();

        public DocumentMangament(ComboBoxEx comboBoxEx)
        {
            Load();
            _comboBoxEx = comboBoxEx;
            _comboBoxEx.DataSource = _Documents.Keys.ToList();
        }

        public Dictionary<string, List<Rectangle>> Load()
        {
            try
            {
                if (!File.Exists(_DocumentName))
                {
                    File.Create(_DocumentName);
                }
                else
                {
                    _Documents =
                        JsonConvert.DeserializeObject<Dictionary<string, List<Rectangle>>>(
                            File.ReadAllText(_DocumentName)) ??
                        new Dictionary<string, List<Rectangle>>();
                }
                return _Documents;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(_DocumentName, JsonConvert.SerializeObject(_Documents));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Remove()
        {
            try
            {
                var documentName = _comboBoxEx.SelectedValue?.ToString() ?? string.Empty;
                if (_Documents.ContainsKey(documentName))
                {
                    _Documents.Remove(documentName);
                    File.WriteAllText(_DocumentName, JsonConvert.SerializeObject(_Documents));
                    _comboBoxEx.DataSource = _Documents.Keys.ToList();
                    MessageBox.Show("Xóa thành công tài liệu: " + documentName, "Thông báo");
                }

                if (_Documents.Count == 0)
                {
                    _comboBoxEx.Text = string.Empty;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Add(string DocumentName, List<Rectangle> Positions)
        {
            try
            {
                if (!_Documents.ContainsKey(DocumentName))
                {
                    _Documents.Add(DocumentName, Positions);
                    File.WriteAllText(_DocumentName, JsonConvert.SerializeObject(_Documents));
                    _comboBoxEx.DataSource = _Documents.Keys.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<Rectangle> Get()
        {
            try
            {
                if (_comboBoxEx.SelectedValue == null) return new List<Rectangle>();

                if (_Documents.ContainsKey(_comboBoxEx.SelectedValue.ToString()))
                {
                    return _Documents[_comboBoxEx.SelectedValue.ToString()];
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new List<Rectangle>();

        }
    }
}