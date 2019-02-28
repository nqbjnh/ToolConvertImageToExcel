using System;
using System.Collections.Generic;
using System.Drawing;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoGroupDetail : Office2007Form
    {
        #region Private data

        private Background[] _BackColor = { new Background(Color.MistyRose),
            new Background(Color.FromArgb(0xE5, 0xFF, 0xDD)), new Background(Color.AliceBlue) };

        private Font _MyFont = new Font(SystemFonts.StatusFont, FontStyle.Bold);

        private string[] _Employees = new string[] { "Betty", "Carmen", "Hosea", "Natasha" };

        #endregion

        public DemoGroupDetail()
        {
            // Initialize the grid
            // and set the sample description text

            InitializeComponent();
            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoGroupDetail.rtf");

            // We are hooking 2 SuperGrid events so that we can add our group
            // detail rows, and so we can keep our detail row totals up to date
            // when the user changes a value that would effect them.

            superGridControl1.GetGroupDetailRows += SuperGridControl1GetGroupDetailRows;
            superGridControl1.CellValueChanged += SuperGridControl1CellValueChanged;
        }

        #region InitializeGrid

        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            Random rand = new Random();

            // Add a few rows

            for (int i = 0; i < 50; i++)
            {
                string date = DateTime.Now.Date.AddDays(rand.Next(-1, 1)).ToShortDateString();

                int n = rand.Next(0, _Employees.Length);

                GridRow row = new GridRow(_Employees[n],
                    date, rand.Next(1, 4) * 10, rand.Next(1, 40));

                panel.Rows.Add(row);
            }
        }

        #endregion

        #region SuperGridControl1CellValueChanged

        void SuperGridControl1CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridRow row = e.GridCell.GridRow;
            GridGroup group = row.Parent as GridGroup;

            if (group != null)
            {
                // If the user changed an Hours value,
                // then update out detail row totals

                if (e.GridCell.GridColumn == e.GridPanel.Columns["Hours"])
                {
                    if (row.IsDetailRow == false)
                    {
                        UpdateParentDetails(group,
                            (int)e.NewValue - (int)e.OldValue);
                    }
                }
            }
        }

        #endregion

        #region UpdateParentDetails

        private void UpdateParentDetails(GridGroup group, int n)
        {
            if (group != null)
            {
                GridRow row = group.Rows[group.Rows.Count - 1] as GridRow;

                if (row != null)
                {
                    GridCell cell = row.Cells["Hours"];

                    cell.Value = (int) cell.Value + n;

                    // Recursively update our outer detail rows

                    UpdateParentDetails(group.Parent as GridGroup, n);
                }
            }
        }

        #endregion

        #region SuperGridControl1GetGroupDetailRows

        void SuperGridControl1GetGroupDetailRows(object sender, GridGetGroupDetailRowsEventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            if (panel.GroupColumns != null)
            {
                if (e.GridGroup.Rows.Count > 0)
                {
                    int index = e.GridGroup.Column.ColumnIndex;
                    int hoursIndex = panel.Columns["Hours"].ColumnIndex;

                    List<GridRow> detailRows = new List<GridRow>();

                    // Add a blank detail row, just for looks

                    if (e.GridGroup.Rows[0] is GridGroup)
                        detailRows.Add(GetNewDetailRow());

                    GridRow row = GetNewDetailRow();

                    row.Cells[index].EditorType = typeof(GridTextBoxXEditControl);
                    row.Cells[index].Value = "Totals for " + e.GridGroup.GroupValue;
                    row.Cells[hoursIndex].Value = TotalHours(e.GridGroup, false);

                    row.CellStyles.Default.Font = _MyFont;

                    // Just for grins, let's add some color to make the 
                    // totals association more readily obvious to the user

                    for (int i = index; i < panel.Columns.Count; i++)
                        row.Cells[i].CellStyles.Default.Background = _BackColor[index];

                    detailRows.Add(row);

                    // Give the detail rows to the grid.  Note that these
                    // rows will be automatically removed when the grouping
                    // is changed or removed

                    e.PostDetailRows = detailRows;
                }
            }
        }

        #region GetNewDetailRow

        private GridRow GetNewDetailRow()
        {
            GridRow row = new GridRow(null, null, null, null);

            // Don't let the user change the row contents

            row.ReadOnly = true;

            return (row);
        }

        #endregion

        #endregion

        #region TotalHours

        private int TotalHours(GridGroup group, bool detailRow)
        {
            int n = 0;

            foreach (GridElement item in group.Rows)
            {
                if (item is GridGroup && detailRow == false)
                    n += TotalHours((GridGroup)item, true);

                else
                {
                    GridRow row = item as GridRow;

                    if (row != null && row.Visible == true)
                    {
                        if (row.IsDetailRow == detailRow)
                        {
                            if (row.Cells[3].Value is int)
                                n += (int) (row.Cells[3].Value);
                        }
                    }
                }
            }

            return (n);
        }

        #endregion
    }
}