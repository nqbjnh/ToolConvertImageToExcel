﻿using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace ToolConvertImageToExcel.Controls
{
    public class ButtonDeleteRow:GridButtonXEditControl
    {
        private GridRow _gridRow;
        private SuperGridControl _superGridControl;
        public ButtonDeleteRow()
        {
            Click += (sender, args) =>
            {
                try
                {
                    var btn = sender as ButtonDeleteRow;
                    var cell = EditorCell;
                    var row = EditorCell.GridRow;
                    var superGrid = cell.SuperGrid;
                    superGrid.PrimaryGrid.Rows.Remove(row);
                    Main._TempPosition.RemoveAt(row.Index);
                }
                catch (System.Exception)
                {
                    
                }
            };
        }

        public override void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            base.InitializeContext(cell, style);

        }
    }
}