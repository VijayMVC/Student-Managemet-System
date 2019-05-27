namespace StudentManager.Screens.Branches
{
	partial class ManageBranchesForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BranchesDataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BranchesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewBranchesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(675, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
			this.toolStripMenuItem1.Text = "|";
			// 
			// addNewBranchesToolStripMenuItem
			// 
			this.addNewBranchesToolStripMenuItem.Name = "addNewBranchesToolStripMenuItem";
			this.addNewBranchesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
			this.addNewBranchesToolStripMenuItem.Text = "Add New Branches";
			this.addNewBranchesToolStripMenuItem.Click += new System.EventHandler(this.addNewBranchesToolStripMenuItem_Click);
			// 
			// BranchesDataGridView
			// 
			this.BranchesDataGridView.AllowUserToAddRows = false;
			this.BranchesDataGridView.AllowUserToDeleteRows = false;
			this.BranchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BranchesDataGridView.Location = new System.Drawing.Point(13, 28);
			this.BranchesDataGridView.Name = "BranchesDataGridView";
			this.BranchesDataGridView.ReadOnly = true;
			this.BranchesDataGridView.Size = new System.Drawing.Size(650, 259);
			this.BranchesDataGridView.TabIndex = 1;
			this.BranchesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BranchesDataGridView_CellContentClick);
			this.BranchesDataGridView.DoubleClick += new System.EventHandler(this.BranchesDataGridView_DoubleClick);
			// 
			// ManageBranchesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 299);
			this.Controls.Add(this.BranchesDataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "ManageBranchesForm";
			this.Text = "Manage Branches ";
			this.Load += new System.EventHandler(this.ManageBranchesForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BranchesDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addNewBranchesToolStripMenuItem;
		private System.Windows.Forms.DataGridView BranchesDataGridView;
	}
}