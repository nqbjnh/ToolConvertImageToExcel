namespace SuperGridDemo
{
    partial class DemoMasterDetailClassic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoMasterDetailClassic));
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding2 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding3 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabContracts = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabSites = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabContacts = new DevComponents.DotNetBar.SuperTabItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sgCustomers = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.sgContacts = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.sgContracts = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.sgSites = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(780, 126);
            this.richTextBox1.TabIndex = 1;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.sgCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.superTabControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.65116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.34884F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 430);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.FixedTabSize = new System.Drawing.Size(0, 27);
            this.superTabControl1.ImageList = this.imageList1;
            this.superTabControl1.Location = new System.Drawing.Point(3, 151);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(778, 276);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabContacts,
            this.tabSites,
            this.tabContracts});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.sgContracts);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 29);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(778, 256);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tabContracts;
            // 
            // tabContracts
            // 
            this.tabContracts.AttachedControl = this.superTabControlPanel3;
            this.tabContracts.GlobalItem = false;
            this.tabContracts.ImageIndex = 1;
            this.tabContracts.ImagePadding.Top = 3;
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Text = "Contracts";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.sgSites);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 29);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(778, 256);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabSites;
            // 
            // tabSites
            // 
            this.tabSites.AttachedControl = this.superTabControlPanel2;
            this.tabSites.GlobalItem = false;
            this.tabSites.ImageIndex = 2;
            this.tabSites.ImagePadding.Top = 3;
            this.tabSites.Name = "tabSites";
            this.tabSites.Text = "Sites";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.sgContacts);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(778, 247);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabContacts;
            // 
            // tabContacts
            // 
            this.tabContacts.AttachedControl = this.superTabControlPanel1;
            this.tabContacts.GlobalItem = false;
            this.tabContacts.ImageIndex = 0;
            this.tabContacts.ImagePadding.Top = 3;
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Text = "Contacts";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Contact");
            this.imageList1.Images.SetKeyName(1, "Contract");
            this.imageList1.Images.SetKeyName(2, "Sites");
            // 
            // sgCustomers
            // 
            this.sgCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sgCustomers.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgCustomers.Location = new System.Drawing.Point(3, 3);
            this.sgCustomers.Name = "sgCustomers";
            this.sgCustomers.PrimaryGrid.MinRowHeight = 20;
            this.sgCustomers.PrimaryGrid.Name = "Customers";
            this.sgCustomers.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.sgCustomers.Size = new System.Drawing.Size(778, 142);
            this.sgCustomers.TabIndex = 0;
            this.sgCustomers.Text = "superGridControl1";
            // 
            // sgContacts
            // 
            this.sgContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgContacts.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgContacts.Location = new System.Drawing.Point(0, 0);
            this.sgContacts.Name = "sgContacts";
            padding1.Left = 5;
            padding1.Right = 5;
            this.sgContacts.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Padding = padding1;
            this.sgContacts.PrimaryGrid.MinRowHeight = 20;
            this.sgContacts.PrimaryGrid.Name = "Contacts";
            this.sgContacts.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.sgContacts.Size = new System.Drawing.Size(778, 247);
            this.sgContacts.TabIndex = 2;
            this.sgContacts.Text = "superGridControl2";
            // 
            // sgContracts
            // 
            this.sgContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgContracts.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgContracts.Location = new System.Drawing.Point(0, 0);
            this.sgContracts.Name = "sgContracts";
            padding2.Left = 5;
            padding2.Right = 5;
            this.sgContracts.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Padding = padding2;
            this.sgContracts.PrimaryGrid.MinRowHeight = 20;
            this.sgContracts.PrimaryGrid.Name = "Contracts";
            this.sgContracts.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.sgContracts.Size = new System.Drawing.Size(778, 256);
            this.sgContracts.TabIndex = 4;
            this.sgContracts.Text = "superGridControl2";
            // 
            // sgSites
            // 
            this.sgSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgSites.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgSites.Location = new System.Drawing.Point(0, 0);
            this.sgSites.Name = "sgSites";
            padding3.Left = 5;
            padding3.Right = 5;
            this.sgSites.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Padding = padding3;
            this.sgSites.PrimaryGrid.MinRowHeight = 20;
            this.sgSites.PrimaryGrid.Name = "Sites";
            this.sgSites.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.sgSites.Size = new System.Drawing.Size(778, 256);
            this.sgSites.TabIndex = 3;
            this.sgSites.Text = "superGridControl2";
            // 
            // DemoMasterDetailClassic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoMasterDetailClassic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Master / Detail, Classic - Sample";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgCustomers;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgContacts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem tabContracts;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabSites;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabContacts;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgContracts;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgSites;
        private System.Windows.Forms.ImageList imageList1;
    }
}