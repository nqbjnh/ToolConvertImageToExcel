namespace SuperGridDemo
{
    partial class DemoRowDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoRowDetail));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.cbxAddPreview = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxGroupByDate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
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
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // cbxAddPreview
            // 
            this.cbxAddPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxAddPreview.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAddPreview.Location = new System.Drawing.Point(515, 530);
            this.cbxAddPreview.Name = "cbxAddPreview";
            this.cbxAddPreview.Size = new System.Drawing.Size(133, 23);
            this.cbxAddPreview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAddPreview.TabIndex = 4;
            this.cbxAddPreview.Text = "Add Detail Preview";
            this.cbxAddPreview.CheckedChanged += new System.EventHandler(this.CbxAddPreviewCheckedChanged);
            // 
            // cbxGroupByDate
            // 
            this.cbxGroupByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxGroupByDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxGroupByDate.Location = new System.Drawing.Point(654, 530);
            this.cbxGroupByDate.Name = "cbxGroupByDate";
            this.cbxGroupByDate.Size = new System.Drawing.Size(111, 23);
            this.cbxGroupByDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxGroupByDate.TabIndex = 3;
            this.cbxGroupByDate.Text = "Group by Period";
            this.cbxGroupByDate.CheckedChanged += new System.EventHandler(this.CbxGroupByDateCheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EmailClosed2.png");
            this.imageList1.Images.SetKeyName(1, "EmailOpen2.png");
            this.imageList1.Images.SetKeyName(2, "EmailOrange.png");
            this.imageList1.Images.SetKeyName(3, "email.png");
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(4, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 25;
            gridColumn1.Name = "Period";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            padding1.Left = 4;
            padding1.Right = 6;
            gridColumn2.CellStyles.Default.ImagePadding = padding1;
            gridColumn2.Name = "User";
            gridColumn2.ReadOnly = true;
            gridColumn2.Width = 150;
            gridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn3.Name = "Date";
            gridColumn3.ReadOnly = true;
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn4.Name = "Read";
            gridColumn4.ReadOnly = true;
            gridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn5.Name = "Size";
            gridColumn5.ReadOnly = true;
            gridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn6.Name = "Attachment";
            gridColumn6.ReadOnly = true;
            gridColumn7.Name = "Message";
            gridColumn7.Width = 200;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn7);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 0;
            background1.Color1 = System.Drawing.Color.AliceBlue;
            background1.Color2 = System.Drawing.Color.LightSteelBlue;
            background1.GradientAngle = 45;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = background1;
            this.superGridControl1.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle;
            this.superGridControl1.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal;
            this.superGridControl1.PrimaryGrid.ImageList = this.imageList1;
            this.superGridControl1.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.superGridControl1.PrimaryGrid.PrimaryColumnIndex = 1;
            this.superGridControl1.PrimaryGrid.RowWhitespaceClickBehavior = DevComponents.DotNetBar.SuperGrid.RowWhitespaceClickBehavior.ExtendSelection;
            this.superGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.superGridControl1.PrimaryGrid.ShowGroupUnderline = false;
            this.superGridControl1.PrimaryGrid.ShowRowHeaders = false;
            this.superGridControl1.Size = new System.Drawing.Size(780, 399);
            this.superGridControl1.TabIndex = 5;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // DemoRowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.cbxAddPreview);
            this.Controls.Add(this.cbxGroupByDate);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoRowDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Row Detail Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAddPreview;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxGroupByDate;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
    }
}