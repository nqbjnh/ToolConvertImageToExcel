using DevComponents.DotNetBar.SuperGrid;
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
                var btn = sender as ButtonDeleteRow;
                var cell = EditorCell;
                var row = EditorCell.GridRow;
                var superGrid = cell.SuperGrid;
                superGrid.PrimaryGrid.Rows.Remove(row);
            };
        }

        public override void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            base.InitializeContext(cell, style);

        }
    }
}