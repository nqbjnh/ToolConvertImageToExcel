using System;
using System.Drawing;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoGrouping1 : Office2007Form
    {
        #region Constants

        private const eTextFormat Tf =
            eTextFormat.VerticalCenter | eTextFormat.HorizontalCenter;

        #endregion

        public DemoGrouping1()
        {
            InitializeComponent();

            // Initialize the grid
            // and set the sample description text

            InitializeGrid();
            InitializeCombos();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoGrouping1.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initialize the grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.Columns["LastName"].EditorType = typeof(MyComboBox);
            panel.Columns["Citizen"].EditorType = typeof(MyCheckBox);
            panel.Columns["Citizen"].EnableHeaderMarkup = true;

            panel.Columns["Citizen"].HeaderText =
                "<div align=\"center\">" +
                    "<font color=\"red\">Citizen</font><br/>" +
                    "<font color=\"green\">Status</font>" +
                "</div>";

            // Add some initial rows for the user

            AddRows();
        }

        #endregion

        #region InitializeCombos

        private void InitializeCombos()
        {
            cboBackImage.Items.Add("None");
            cboBackImage.Items.Add("BackstageBlue");
            cboBackImage.Items.Add("BlueCircle");
            cboBackImage.Items.Add("Grid");
            cboBackImage.Items.Add("ThumbsUp");
            cboBackImage.SelectedItem = "None";

            cboBackLayout.Items.AddRange(Enum.GetNames(typeof(GridBackgroundImageLayout)));
            cboBackLayout.SelectedItem = "Tile";

            cboGroupBoxEffects.Items.AddRange(Enum.GetNames(typeof(GroupBoxEffects)));
            cboGroupBoxEffects.SelectedItem = "Move";
        }

        #endregion

        #region AddRows

        /// <summary>
        /// Adds 500 random data rows for the user to filter
        /// </summary>
        private void AddRows()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            superGridControl1.BeginUpdate();

            for (int i = 0; i < 500; i++)
            {
                MyEmployee emp = MyEmployee.GetNewEmployee(false);

                object[] ob1 = new object[]
                {
                    emp.LastName, emp.FirstName,
                    emp.Age, emp.HireDate, emp.Citizen
                };

                panel.Rows.Add(new GridRow(ob1));
            }

            superGridControl1.EndUpdate();
        }

        #endregion

        #region SuperGridControl1PostRenderGroupBox

        /// <summary>
        /// Handle post rendering of our own user data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1PostRenderGroupBox(
            object sender, GridPostRenderGroupBoxEventArgs e)
        {
            if (e.RenderParts == RenderParts.Content)
            {
                if (e.GridGroupBox.Column.Name.Equals("LastName"))
                    PostRenderLastName(e);

                else if (e.GridGroupBox.Column.Name.Equals("Age"))
                    PostRenderAge(e);
            }
        }

        #region PostRenderLastName

        /// <summary>
        /// Adds an image and some nonsensical text
        /// to the bottom of the "LastName" GroupBox.
        /// </summary>
        /// <param name="e"></param>
        private void PostRenderLastName(GridPostRenderGroupBoxEventArgs e)
        {
            Rectangle r = e.Bounds;
            Graphics g = e.Graphics;

            r.Y = r.Bottom - 40;
            r.Height = 40;

            using (Image image = imageList1.Images["Family"])
            {
                if (image != null)
                {
                    Rectangle t = r;
                    t.Size = image.Size;

                    t.X += (r.Width - t.Width) / 2;
                    t.Y += (r.Height - t.Height) / 2 - 10;

                    g.DrawImage(image, t);
                }
            }

            r.Y += 20;
            r.Height -= 20;

            TextDrawing.DrawString(g,
                "Patronimic", SystemFonts.DefaultFont, Color.Crimson, r, Tf);
        }

        #endregion

        #region PostRenderAge

        /// <summary>
        /// Renders some nonsensical text to the top of the "Age" GroupBox
        /// </summary>
        /// <param name="e"></param>
        private void PostRenderAge(GridPostRenderGroupBoxEventArgs e)
        {
            Rectangle r = e.Bounds;
            Graphics g = e.Graphics;

            r.Y += 2;
            r.Height = 20;

            using (Font font = new Font(SystemFonts.IconTitleFont, FontStyle.Italic))
            {
                TextDrawing.DrawString(g,
                    "(Estimated)", font, Color.BlueViolet, r, Tf);
            }
        }

        #endregion

        #endregion

        #region SuperGridControl1ConfigureGroupBox

        /// <summary>
        /// Configures the provided GroupBox for the
        /// current user display settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1ConfigureGroupBox(
            object sender, GridConfigureGroupBoxEventArgs e)
        {
            GridGroupBox box = e.GridGroupBox;
            
            if (box.Column.Name.Equals("LastName"))
            {
                box.Padding = new Padding(0, 0, 5, 40);
                box.GroupBoxStyle = GroupBoxStyle.RoundedRectangular;
            }
            else if (box.Column.Name.Equals("Age"))
            {
                box.Padding = new Padding(0, 0, 20, 5);
                box.GroupBoxStyle = GroupBoxStyle.RoundedRectangular;

                Size size = box.ContentSize;
                size.Width = 80;

                box.ContentSize = size;
            }
        }

        #endregion

        #region Display change support

        #region CboBackImageSelectedIndexChanged

        private void CboBackImageSelectedIndexChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            switch ((string) cboBackImage.SelectedItem)
            {
                case "BackstageBlue":
                    groupBy.BackgroundImage =
                        ShellServices.LoadBitmap("SuperGridDemo.Resources.BackstageBlue.png");

                    cboBackLayout.SelectedItem =
                        Enum.GetName(typeof(GridBackgroundImageLayout), GridBackgroundImageLayout.Stretch);
                    break;

                case "BlueCircle":
                    groupBy.BackgroundImage =
                        ShellServices.LoadBitmap("SuperGridDemo.Resources.BlueCircle.png");

                    cboBackLayout.SelectedItem =
                        Enum.GetName(typeof(GridBackgroundImageLayout), GridBackgroundImageLayout.Tile);
                    break;

                case "Grid":
                    groupBy.BackgroundImage =
                        ShellServices.LoadBitmap("SuperGridDemo.Resources.Grid.png");

                    cboBackLayout.SelectedItem =
                        Enum.GetName(typeof(GridBackgroundImageLayout), GridBackgroundImageLayout.Tile);
                    break;

                case "ThumbsUp":
                    groupBy.BackgroundImage =
                        ShellServices.LoadBitmap("SuperGridDemo.Resources.ThumbsUp.png");

                    cboBackLayout.SelectedItem =
                        Enum.GetName(typeof(GridBackgroundImageLayout), GridBackgroundImageLayout.Tile);
                    break;

                default:
                    groupBy.BackgroundImage = null;
                    break;
            }

        }

        #endregion

        #region CboBackLayoutSelectedIndexChanged

        /// <summary>
        /// Handles Background Image Layout changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboBackLayoutSelectedIndexChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.BackgroundImageLayout = (GridBackgroundImageLayout)
                Enum.Parse(typeof(GridBackgroundImageLayout), (string)cboBackLayout.SelectedItem);
        }

        #endregion

        #region CbxRoundRectGroupBoxCheckedChanged

        /// <summary>
        /// Handles user selection of Rectangular or
        /// RoundedRectangular GroupBox styles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxRoundRectGroupBoxCheckedChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.GroupBoxStyle = (cbxRoundRectGroupBox.Checked == true)
                ? GroupBoxStyle.RoundedRectangular : GroupBoxStyle.Rectangular;
        }

        #endregion

        #region CbxUseColumnColorsCheckedChanged

        /// <summary>
        /// Handles user selection for using the default column header
        /// color definitions or ones set for the GroupBy row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxUseColumnColorsCheckedChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.UseColumnHeaderColors = cbxUseColumnColors.Checked;
        }

        #endregion

        #region CbxAddUserTextCheckedChanged

        /// <summary>
        /// Handles selection to add user content to
        /// a couple of the GroupBox items (LastName and Age)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAddUserTextCheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddUserText.Checked == true)
            {
                superGridControl1.ConfigureGroupBox += SuperGridControl1ConfigureGroupBox;
                superGridControl1.PostRenderGroupBox += SuperGridControl1PostRenderGroupBox;
            }
            else
            {
                superGridControl1.ConfigureGroupBox -= SuperGridControl1ConfigureGroupBox;
                superGridControl1.PostRenderGroupBox -= SuperGridControl1PostRenderGroupBox;
            }

            superGridControl1.PrimaryGrid.InvalidateLayout();
        }

        #endregion

        #region SlCornerRadiusValueChanged

        /// <summary>
        /// Handles corner radius value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlCornerRadiusValueChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.CornerRadius = slCornerRadius.Value;
        }

        #endregion

        #region CbxFlatLayoutCheckedChanged

        /// <summary>
        /// Handles FlatLayout style changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxFlatLayoutCheckedChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.GroupBoxLayout = (cbxFlatLayout.Checked)
                ? GroupBoxLayout.Flat : GroupBoxLayout.Hierarchical;
        }

        #endregion

        #region CbxAllowSortCheckedChanged

        /// <summary>
        /// Handles AllowSort changes. When sorting is disabled
        /// plain double-clicks can remove the item from the GroupBy row.
        /// When sorting is enabled, shift-double-clicks are needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAllowSortCheckedChanged(object sender, EventArgs e)
        {
            GridGroupByRow groupBy = superGridControl1.PrimaryGrid.GroupByRow;

            groupBy.AllowUserSort = cbxAllowSort.Checked;
        }

        #endregion

        #region CboGroupBoxEffectsSelectedIndexChanged

        /// <summary>
        /// Handles user changes in the GroupBoxEffects setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboGroupBoxEffectsSelectedIndexChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            GroupBoxEffects effects = (GroupBoxEffects)
                Enum.Parse(typeof(GroupBoxEffects), (string)cboGroupBoxEffects.SelectedItem);

            // The following code will change the default - which will
            // effect every column except the 'HideDate' column because
            // it is explicitly set to 'None' by default.

            panel.GroupByRow.GroupBoxEffects = effects;
        }

        #endregion

        #region CbxVisibleCheckedChanged

        /// <summary>
        /// Handles GroupBy row visibility changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxVisibleCheckedChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.GroupByRow.Visible = cbxVisible.Checked;
        }

        #endregion

        #endregion
    }
}