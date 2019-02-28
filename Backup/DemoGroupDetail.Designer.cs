namespace SuperGridDemo
{
    partial class DemoGroupDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGroupDetail));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
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
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowInsert = true;
            this.superGridControl1.PrimaryGrid.AutoExpandSetGroup = true;
            gridColumn1.Name = "Employee";
            gridColumn1.Width = 200;
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            gridColumn2.Name = "Date";
            gridColumn2.Width = 150;
            gridColumn3.FilterAutoScan = true;
            gridColumn3.Name = "WorkType";
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn4.FilterAutoScan = true;
            gridColumn4.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.None;
            gridColumn4.Name = "Hours";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl1.PrimaryGrid.Filter.Visible = true;
            this.superGridControl1.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy;
            this.superGridControl1.PrimaryGrid.GroupByRow.GroupBoxStyle = DevComponents.DotNetBar.SuperGrid.GroupBoxStyle.RoundedRectangular;
            this.superGridControl1.PrimaryGrid.GroupByRow.Visible = true;
            this.superGridControl1.PrimaryGrid.GroupByRow.WatermarkText = "Drag a column header here to group by that column - Excluding the Hours column.";
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(784, 439);
            this.superGridControl1.TabIndex = 6;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // DemoGroupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGroupDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Group Detail Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
    }
}