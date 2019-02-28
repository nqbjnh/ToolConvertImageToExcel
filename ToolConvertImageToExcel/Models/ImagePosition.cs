using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolConvertImageToExcel.Models
{
    public class ImagePosition
    {
        public int Index { get; set; }          
        public string ImageCrop { get; set; }
        public string ImageContent { get; set; }
        public Rectangle ImageRectangle { get; set; }
        public string ImagePos
        {
            get
            {
                return ImageRectangle.X + "," + ImageRectangle.Y + "," + ImageRectangle.Width + "," +
                       ImageRectangle.Height; }
            set { }
        }

    }
}
