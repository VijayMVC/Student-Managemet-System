namespace StudentManager.Screens
{
	partial class DashboardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.NewStudentToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ManageBranchesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ManageEmployeesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.DeleteRecordToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.CloseToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.StudentDataGridView = new System.Windows.Forms.DataGridView();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(731, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStudentToolStripButton,
            this.toolStripSeparator1,
            this.ManageBranchesToolStripButton,
            this.toolStripSeparator2,
            this.ManageEmployeesToolStripButton,
            this.toolStripSeparator3,
            this.DeleteRecordToolStripButton,
            this.toolStripSeparator4,
            this.CloseToolStripButton,
            this.toolStripSeparator5,
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(731, 54);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// NewStudentToolStripButton
			// 
			this.NewStudentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewStudentToolStripButton.Image")));
			this.NewStudentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NewStudentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewStudentToolStripButton.Name = "NewStudentToolStripButton";
			this.NewStudentToolStripButton.Size = new System.Drawing.Size(79, 51);
			this.NewStudentToolStripButton.Text = "New Student";
			this.NewStudentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.NewStudentToolStripButton.Click += new System.EventHandler(this.NewStudentToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
			// 
			// ManageBranchesToolStripButton
			// 
			this.ManageBranchesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageBranchesToolStripButton.Image")));
			this.ManageBranchesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ManageBranchesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ManageBranchesToolStripButton.Name = "ManageBranchesToolStripButton";
			this.ManageBranchesToolStripButton.Size = new System.Drawing.Size(105, 51);
			this.ManageBranchesToolStripButton.Text = "Manage Branches";
			this.ManageBranchesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ManageBranchesToolStripButton.ToolTipText = "Manage Branches";
			this.ManageBranchesToolStripButton.Click += new System.EventHandler(this.ManageBranchesToolStripButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
			// 
			// ManageEmployeesToolStripButton
			// 
			this.ManageEmployeesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageEmployeesToolStripButton.Image")));
			this.ManageEmployeesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ManageEmployeesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ManageEmployeesToolStripButton.Name = "ManageEmployeesToolStripButton";
			this.ManageEmployeesToolStripButton.Size = new System.Drawing.Size(114, 51);
			this.ManageEmployeesToolStripButton.Text = "Manage Employees";
			this.ManageEmployeesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ManageEmployeesToolStripButton.Click += new System.EventHandler(this.ManageEmployeesToolStripButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
			// 
			// DeleteRecordToolStripButton
			// 
			this.DeleteRecordToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRecordToolStripButton.Image")));
			this.DeleteRecordToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.DeleteRecordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteRecordToolStripButton.Name = "DeleteRecordToolStripButton";
			this.DeleteRecordToolStripButton.Size = new System.Drawing.Size(84, 51);
			this.DeleteRecordToolStripButton.Text = "Delete Record";
			this.DeleteRecordToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.DeleteRecordToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.DeleteRecordToolStripButton.ToolTipText = "Delete Record";
			this.DeleteRecordToolStripButton.Click += new System.EventHandler(this.DeleteRecordToolStripButton_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
			// 
			// CloseToolStripButton
			// 
			this.CloseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseToolStripButton.Image")));
			this.CloseToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CloseToolStripButton.Name = "CloseToolStripButton";
			this.CloseToolStripButton.Size = new System.Drawing.Size(40, 51);
			this.CloseToolStripButton.Text = "Close";
			this.CloseToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CloseToolStripButton.Click += new System.EventHandler(this.CloseToolStripButton_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(96, 51);
			this.toolStripLabel1.Text = "Search By Name:";
			// 
			// StudentDataGridView
			// 
			this.StudentDataGridView.AllowUserToAddRows = false;
			this.StudentDataGridView.AllowUserToDeleteRows = false;
			this.StudentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentDataGridView.Location = new System.Drawing.Point(12, 81);
			this.StudentDataGridView.Name = "StudentDataGridView";
			this.StudentDataGridView.ReadOnly = true;
			this.StudentDataGridView.Size = new System.Drawing.Size(707, 301);
			this.StudentDataGridView.TabIndex = 2;
			this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
			this.StudentDataGridView.DoubleClick += new System.EventHandler(this.StudentDataGridView_DoubleClick);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(557, 40);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(162, 23);
			this.SearchTextBox.TabIndex = 9;
			this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
			// 
			// DashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 392);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.StudentDataGridView);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "DashboardForm";
			this.ShowInTaskbar = true;
			this.Text = "DashboardForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DashboardForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton NewStudentToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ManageBranchesToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton ManageEmployeesToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton CloseToolStripButton;
		private System.Windows.Forms.ToolStripButton DeleteRecordToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		public System.Windows.Forms.DataGridView StudentDataGridView;
		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
	}
}