using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ToolConvertImageToExcel.Services
{
    public class DocumentMangament
    {
        private string _DocumentName = Directory.GetCurrentDirectory() + @"\document.json";
        public Dictionary<string,List<Rectangle>> _Documents { get; set; } = new Dictionary<string, List<Rectangle>>();
        public Dictionary<string, List<Rectangle>> Load()
        {
            try
            {
                _Documents.Clear();
                _Documents = JsonConvert.DeserializeObject<Dictionary<string, List<Rectangle>>>(File.ReadAllText(_DocumentName));
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

        public void Remove(string DocumentName)
        {
            try
            {
                if (_Documents.ContainsKey(DocumentName))
                {
                    _Documents.Remove(DocumentName);
                    File.WriteAllText(_DocumentName, JsonConvert.SerializeObject(_Documents));
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
                    _Documents.Add(DocumentName,Positions);
                    File.WriteAllText(_DocumentName, JsonConvert.SerializeObject(_Documents));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}