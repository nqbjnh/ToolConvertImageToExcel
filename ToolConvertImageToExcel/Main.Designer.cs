namespace ToolConvertImageToExcel
{
    partial class Main
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.superGridControl2 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddToExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadPosition = new System.Windows.Forms.Button();
            this.btnSavePosition = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(1348, 721);
            this.splitContainer1.SplitterDistance = 674;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 677);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.ForeColor = System.Drawing.Color.Black;
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(674, 677);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxImage_Paint);
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            this.pictureBoxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseMove);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.btnUploadImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.ForeColor = System.Drawing.Color.Black;
            this.btnUploadImage.Location = new System.Drawing.Point(3, 3);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(123, 36);
            this.btnUploadImage.TabIndex = 0;
            this.btnUploadImage.Text = "Tải hình";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 677);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.superGridControl2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 353);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel7.Controls.Add(this.btnExportExcel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(670, 43);
            this.panel7.TabIndex = 7;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(5, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(123, 36);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Xuất file excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // superGridControl2
            // 
            this.superGridControl2.BackColor = System.Drawing.Color.White;
            this.superGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl2.ForeColor = System.Drawing.Color.Black;
            this.superGridControl2.Location = new System.Drawing.Point(0, 0);
            this.superGridControl2.Name = "superGridControl2";
            this.superGridControl2.Size = new System.Drawing.Size(670, 353);
            this.superGridControl2.TabIndex = 5;
            this.superGridControl2.Text = "superGridControl2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel4.Controls.Add(this.superGridControl1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 324);
            this.panel4.TabIndex = 7;
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(0, 0);
            this.superGridControl1.Name = "superGridControl1";
            gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridImageEditControl);
            gridColumn1.HeaderText = "Hình";
            gridColumn1.Name = "";
            gridColumn1.Width = 200;
            gridColumn2.HeaderText = "Nội dung hình";
            gridColumn2.Name = "CellImageContent";
            gridColumn2.Width = 250;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn3.HeaderText = "Tọa độ hình";
            gridColumn3.Name = "";
            gridColumn3.Width = 150;
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            gridColumn4.HeaderText = "";
            gridColumn4.MinimumWidth = 0;
            gridColumn4.Name = "CellDeleteRow";
            gridColumn4.Width = 50;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.Size = new System.Drawing.Size(670, 276);
            this.superGridControl1.TabIndex = 2;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel6.Controls.Add(this.btnAddToExcel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(670, 49);
            this.panel6.TabIndex = 5;
            // 
            // btnAddToExcel
            // 
            this.btnAddToExcel.BackColor = System.Drawing.Color.White;
            this.btnAddToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnAddToExcel.Location = new System.Drawing.Point(5, 7);
            this.btnAddToExcel.Name = "btnAddToExcel";
            this.btnAddToExcel.Size = new System.Drawing.Size(123, 36);
            this.btnAddToExcel.TabIndex = 4;
            this.btnAddToExcel.Text = "Đẩy vào file excel";
            this.btnAddToExcel.UseVisualStyleBackColor = false;
            this.btnAddToExcel.Click += new System.EventHandler(this.btnAddToExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.btnLoadPosition);
            this.panel2.Controls.Add(this.btnSavePosition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 44);
            this.panel2.TabIndex = 7;
            // 
            // btnLoadPosition
            // 
            this.btnLoadPosition.BackColor = System.Drawing.Color.White;
            this.btnLoadPosition.ForeColor = System.Drawing.Color.Black;
            this.btnLoadPosition.Location = new System.Drawing.Point(132, 5);
            this.btnLoadPosition.Name = "btnLoadPosition";
            this.btnLoadPosition.Size = new System.Drawing.Size(123, 36);
            this.btnLoadPosition.TabIndex = 2;
            this.btnLoadPosition.Text = "Tải tọa độ";
            this.btnLoadPosition.UseVisualStyleBackColor = false;
            this.btnLoadPosition.Click += new System.EventHandler(this.btnLoadPosition_Click);
            // 
            // btnSavePosition
            // 
            this.btnSavePosition.BackColor = System.Drawing.Color.White;
            this.btnSavePosition.ForeColor = System.Drawing.Color.Black;
            this.btnSavePosition.Location = new System.Drawing.Point(3, 5);
            this.btnSavePosition.Name = "btnSavePosition";
            this.btnSavePosition.Size = new System.Drawing.Size(123, 36);
            this.btnSavePosition.TabIndex = 1;
            this.btnSavePosition.Text = "Lưu tọa độ";
            this.btnSavePosition.UseVisualStyleBackColor = false;
            this.btnSavePosition.Click += new System.EventHandler(this.btnSavePosition_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvertImageToExcel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private System.Windows.Forms.Button btnAddToExcel;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSavePosition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLoadPosition;
    }
}