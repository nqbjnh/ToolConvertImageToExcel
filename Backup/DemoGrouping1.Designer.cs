namespace SuperGridDemo
{
    partial class DemoGrouping1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGrouping1));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn24 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn25 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Background background21 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend21 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            DevComponents.DotNetBar.SuperGrid.Style.Background background22 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend22 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            DevComponents.DotNetBar.SuperGrid.Style.Background background23 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend23 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            DevComponents.DotNetBar.SuperGrid.Style.Background background24 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend24 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            DevComponents.DotNetBar.SuperGrid.Style.Background background25 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend25 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.cboBackImage = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboBackLayout = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbxRoundRectGroupBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxUseColumnColors = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxAddUserText = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.slCornerRadius = new DevComponents.DotNetBar.Controls.Slider();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbxFlatLayout = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxAllowSort = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboGroupBoxEffects = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbxVisible = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(780, 113);
            this.richTextBox1.TabIndex = 2;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(10))))));
            // 
            // cboBackImage
            // 
            this.cboBackImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboBackImage.DisplayMember = "Text";
            this.cboBackImage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBackImage.FormattingEnabled = true;
            this.cboBackImage.ItemHeight = 14;
            this.cboBackImage.Location = new System.Drawing.Point(113, 583);
            this.cboBackImage.Name = "cboBackImage";
            this.cboBackImage.Size = new System.Drawing.Size(118, 20);
            this.cboBackImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBackImage.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cboBackImage, "Sets the Backgroung Image for the GroupBy area");
            this.cboBackImage.SelectedIndexChanged += new System.EventHandler(this.CboBackImageSelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 581);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(102, 25);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Background Image:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX1.WordWrap = true;
            // 
            // cboBackLayout
            // 
            this.cboBackLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboBackLayout.DisplayMember = "Text";
            this.cboBackLayout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBackLayout.FormattingEnabled = true;
            this.cboBackLayout.ItemHeight = 14;
            this.cboBackLayout.Location = new System.Drawing.Point(113, 612);
            this.cboBackLayout.Name = "cboBackLayout";
            this.cboBackLayout.Size = new System.Drawing.Size(118, 20);
            this.cboBackLayout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBackLayout.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboBackLayout, "Sets the Backgroung Image layout for the GroupBy area");
            this.cboBackLayout.SelectedIndexChanged += new System.EventHandler(this.CboBackLayoutSelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(5, 612);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(102, 22);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Background Layout:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX3.WordWrap = true;
            // 
            // cbxRounderGroupBox
            // 
            this.cbxRoundRectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxRoundRectGroupBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRoundRectGroupBox.Location = new System.Drawing.Point(617, 560);
            this.cbxRoundRectGroupBox.Name = "cbxRounderGroupBox";
            this.cbxRoundRectGroupBox.Size = new System.Drawing.Size(155, 23);
            this.cbxRoundRectGroupBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxRoundRectGroupBox.TabIndex = 12;
            this.cbxRoundRectGroupBox.Text = "All Rounded GroupBoxes";
            this.toolTip1.SetToolTip(this.cbxRoundRectGroupBox, "Sets whether to make all GroupBy boxes have rounded corners.");
            this.cbxRoundRectGroupBox.CheckedChanged += new System.EventHandler(this.CbxRoundRectGroupBoxCheckedChanged);
            // 
            // cbxUseColumnColors
            // 
            this.cbxUseColumnColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxUseColumnColors.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxUseColumnColors.Checked = true;
            this.cbxUseColumnColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseColumnColors.CheckValue = "Y";
            this.cbxUseColumnColors.Location = new System.Drawing.Point(410, 583);
            this.cbxUseColumnColors.Name = "cbxUseColumnColors";
            this.cbxUseColumnColors.Size = new System.Drawing.Size(163, 23);
            this.cbxUseColumnColors.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxUseColumnColors.TabIndex = 13;
            this.cbxUseColumnColors.Text = "Use ColumnHeader Colors";
            this.toolTip1.SetToolTip(this.cbxUseColumnColors, "Sets whether the GroupBy boxes take their color settings from their associated Co" +
                    "lumnHeader");
            this.cbxUseColumnColors.CheckedChanged += new System.EventHandler(this.CbxUseColumnColorsCheckedChanged);
            // 
            // cbxAddUserText
            // 
            this.cbxAddUserText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxAddUserText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAddUserText.Location = new System.Drawing.Point(260, 612);
            this.cbxAddUserText.Name = "cbxAddUserText";
            this.cbxAddUserText.Size = new System.Drawing.Size(124, 23);
            this.cbxAddUserText.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAddUserText.TabIndex = 14;
            this.cbxAddUserText.Text = "Add User Rendering";
            this.toolTip1.SetToolTip(this.cbxAddUserText, "Sets whether user rendered items are added to the LastName and Age boxes.");
            this.cbxAddUserText.CheckedChanged += new System.EventHandler(this.CbxAddUserTextCheckedChanged);
            // 
            // slCornerRadius
            // 
            this.slCornerRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.slCornerRadius.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slCornerRadius.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom;
            this.slCornerRadius.Location = new System.Drawing.Point(617, 594);
            this.slCornerRadius.Maximum = 40;
            this.slCornerRadius.Name = "slCornerRadius";
            this.slCornerRadius.Size = new System.Drawing.Size(155, 30);
            this.slCornerRadius.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slCornerRadius.TabIndex = 15;
            this.slCornerRadius.Text = "GroupBox Corner Radius";
            this.toolTip1.SetToolTip(this.slCornerRadius, "Sets the Rounder Corner radius.");
            this.slCornerRadius.Value = 5;
            this.slCornerRadius.ValueChanged += new System.EventHandler(this.SlCornerRadiusValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Family");
            // 
            // cbxFlatLayout
            // 
            this.cbxFlatLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxFlatLayout.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxFlatLayout.Location = new System.Drawing.Point(260, 583);
            this.cbxFlatLayout.Name = "cbxFlatLayout";
            this.cbxFlatLayout.Size = new System.Drawing.Size(124, 23);
            this.cbxFlatLayout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxFlatLayout.TabIndex = 16;
            this.cbxFlatLayout.Text = "Flat Layout";
            this.toolTip1.SetToolTip(this.cbxFlatLayout, "Sets whether the GroupBy area boxes are laid out in a flat orientation");
            this.cbxFlatLayout.CheckedChanged += new System.EventHandler(this.CbxFlatLayoutCheckedChanged);
            // 
            // cbxAllowSort
            // 
            this.cbxAllowSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxAllowSort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAllowSort.Checked = true;
            this.cbxAllowSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAllowSort.CheckValue = "Y";
            this.cbxAllowSort.Location = new System.Drawing.Point(410, 554);
            this.cbxAllowSort.Name = "cbxAllowSort";
            this.cbxAllowSort.Size = new System.Drawing.Size(124, 23);
            this.cbxAllowSort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAllowSort.TabIndex = 17;
            this.cbxAllowSort.Text = "Allow Group Sort";
            this.toolTip1.SetToolTip(this.cbxAllowSort, "Sets whether the user is allowed to sort groups via GroupBy boxes");
            this.cbxAllowSort.CheckedChanged += new System.EventHandler(this.CbxAllowSortCheckedChanged);
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Checked = true;
            this.checkBoxX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX2.CheckValue = "Y";
            this.checkBoxX2.Location = new System.Drawing.Point(410, 612);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(181, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 18;
            this.checkBoxX2.Text = "Remove Group on DoubleClick";
            this.toolTip1.SetToolTip(this.checkBoxX2, "Sets whether doubleclicks on a GroupBy box will remove it from the GroupBy area.\r" +
                    "\nIf user sorting is enabled, the Ctrl key must be pressed.");
            // 
            // cboGroupBoxEffects
            // 
            this.cboGroupBoxEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboGroupBoxEffects.DisplayMember = "Text";
            this.cboGroupBoxEffects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGroupBoxEffects.FormattingEnabled = true;
            this.cboGroupBoxEffects.ItemHeight = 14;
            this.cboGroupBoxEffects.Location = new System.Drawing.Point(113, 552);
            this.cboGroupBoxEffects.Name = "cboGroupBoxEffects";
            this.cboGroupBoxEffects.Size = new System.Drawing.Size(70, 20);
            this.cboGroupBoxEffects.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGroupBoxEffects.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cboGroupBoxEffects, "Controls the effects of dragging a column header into the GroupBy area.\r\nThis is " +
                    "a column by column setting (here, though, we set all columns - except the HireDa" +
                    "te column).");
            this.cboGroupBoxEffects.SelectedIndexChanged += new System.EventHandler(this.CboGroupBoxEffectsSelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(5, 552);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Drag Effects:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX2.WordWrap = true;
            // 
            // cbxVisible
            // 
            this.cbxVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxVisible.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxVisible.Checked = true;
            this.cbxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxVisible.CheckValue = "Y";
            this.cbxVisible.Location = new System.Drawing.Point(260, 554);
            this.cbxVisible.Name = "cbxVisible";
            this.cbxVisible.Size = new System.Drawing.Size(124, 23);
            this.cbxVisible.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxVisible.TabIndex = 21;
            this.cbxVisible.Text = "Visible";
            this.toolTip1.SetToolTip(this.cbxVisible, "GrouBy area visibility");
            this.cbxVisible.CheckedChanged += new System.EventHandler(this.CbxVisibleCheckedChanged);
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            this.superGridControl1.PrimaryGrid.ColumnHeader.FilterImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.superGridControl1.PrimaryGrid.ColumnHeader.FilterImageVisibility = DevComponents.DotNetBar.SuperGrid.ImageVisibility.Never;
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 35;
            this.superGridControl1.PrimaryGrid.ColumnHeader.SortImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            gridColumn21.DataType = null;
            gridColumn21.HeaderStyles.Default.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn21.Name = "LastName";
            gridColumn21.Width = 180;
            gridColumn22.DataType = null;
            gridColumn22.FilterAutoScan = true;
            gridColumn22.HeaderStyles.Default.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn22.Name = "FirstName";
            gridColumn22.Width = 180;
            gridColumn23.DataType = null;
            gridColumn23.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn23.Name = "Age";
            gridColumn24.DataType = null;
            gridColumn24.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            gridColumn24.EnableHeaderMarkup = true;
            gridColumn24.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.None;
            gridColumn24.HeaderText = "Hire Date";
            gridColumn24.Name = "HireDate";
            gridColumn25.DataType = null;
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn25.Name = "Citizen";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn21);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn22);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn23);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn24);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn25);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 24;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            backColorBlend21.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))))};
            background21.BackColorBlend = backColorBlend21;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupByStyles.Default.Background = background21;
            backColorBlend22.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))), ((int)(((byte)(236))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))))};
            backColorBlend22.Positions = new float[] {
        0F,
        0.5F,
        0.5F,
        1F};
            background22.BackColorBlend = backColorBlend22;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupByStyles.Default.GroupBoxBackground = background22;
            backColorBlend23.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(148)))), ((int)(((byte)(216)))), ((int)(((byte)(94))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(3))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))))};
            backColorBlend23.Positions = new float[] {
        0F,
        0.5F,
        0.5F,
        1F};
            background23.BackColorBlend = backColorBlend23;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupByStyles.MouseOver.GroupBoxBackground = background23;
            backColorBlend24.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(148)))), ((int)(((byte)(216)))), ((int)(((byte)(94))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(3))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))))};
            backColorBlend24.Positions = new float[] {
        0F,
        0.5F,
        0.5F,
        1F};
            background24.BackColorBlend = backColorBlend24;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupByStyles.Selected.GroupBoxBackground = background24;
            backColorBlend25.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(148)))), ((int)(((byte)(216)))), ((int)(((byte)(94))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(3))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))), ((int)(((byte)(97)))))};
            background25.BackColorBlend = backColorBlend25;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupByStyles.SelectedMouseOver.GroupBoxBackground = background25;
            this.superGridControl1.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl1.PrimaryGrid.Filter.Visible = true;
            this.superGridControl1.PrimaryGrid.GroupByRow.FilterImageVisibility = DevComponents.DotNetBar.SuperGrid.ImageVisibility.Auto;
            this.superGridControl1.PrimaryGrid.GroupByRow.Visible = true;
            this.superGridControl1.PrimaryGrid.NullString = "<<null>>";
            this.superGridControl1.PrimaryGrid.RowHeaderWidth = 45;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.Size = new System.Drawing.Size(784, 420);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // DemoGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.cbxVisible);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cboGroupBoxEffects);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.cbxAllowSort);
            this.Controls.Add(this.cbxFlatLayout);
            this.Controls.Add(this.slCornerRadius);
            this.Controls.Add(this.cbxAddUserText);
            this.Controls.Add(this.cbxUseColumnColors);
            this.Controls.Add(this.cbxRoundRectGroupBox);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cboBackLayout);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cboBackImage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.superGridControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 290);
            this.Name = "DemoGrouping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Grouping";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBackImage;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBackLayout;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRoundRectGroupBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxUseColumnColors;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAddUserText;
        private DevComponents.DotNetBar.Controls.Slider slCornerRadius;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxFlatLayout;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAllowSort;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGroupBoxEffects;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxVisible;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}