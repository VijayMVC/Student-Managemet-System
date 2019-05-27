namespace StudentManager.Screens.Branches
{
	partial class BranchInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchInfoForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.GetPhotoPictureBox = new System.Windows.Forms.PictureBox();
			this.ClearPictureBox = new System.Windows.Forms.PictureBox();
			this.LogoPictureBox = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.PostralCodeTextBox = new System.Windows.Forms.TextBox();
			this.DistrictNameComboBox = new System.Windows.Forms.ComboBox();
			this.CityNameComboBox = new System.Windows.Forms.ComboBox();
			this.AddressLineTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.WebSiteAddressTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TelephoneTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BranchNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LabelTopPanel = new System.Windows.Forms.Panel();
			this.TopPanelLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GetPhotoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClearPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
			this.LabelTopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveRecordToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(806, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
			// saveRecordToolStripMenuItem
			// 
			this.saveRecordToolStripMenuItem.Name = "saveRecordToolStripMenuItem";
			this.saveRecordToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.saveRecordToolStripMenuItem.Text = "Save Record";
			this.saveRecordToolStripMenuItem.Click += new System.EventHandler(this.saveRecordToolStripMenuItem_Click);
			// 
			// TopPanel
			// 
			this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TopPanel.Controls.Add(this.GetPhotoPictureBox);
			this.TopPanel.Controls.Add(this.ClearPictureBox);
			this.TopPanel.Controls.Add(this.LogoPictureBox);
			this.TopPanel.Controls.Add(this.label9);
			this.TopPanel.Controls.Add(this.label8);
			this.TopPanel.Controls.Add(this.label7);
			this.TopPanel.Controls.Add(this.PostralCodeTextBox);
			this.TopPanel.Controls.Add(this.DistrictNameComboBox);
			this.TopPanel.Controls.Add(this.CityNameComboBox);
			this.TopPanel.Controls.Add(this.AddressLineTextBox);
			this.TopPanel.Controls.Add(this.label6);
			this.TopPanel.Controls.Add(this.WebSiteAddressTextBox);
			this.TopPanel.Controls.Add(this.label5);
			this.TopPanel.Controls.Add(this.TelephoneTextBox);
			this.TopPanel.Controls.Add(this.label4);
			this.TopPanel.Controls.Add(this.EmailAddressTextBox);
			this.TopPanel.Controls.Add(this.label3);
			this.TopPanel.Controls.Add(this.BranchNameTextBox);
			this.TopPanel.Controls.Add(this.label2);
			this.TopPanel.Controls.Add(this.LabelTopPanel);
			this.TopPanel.Location = new System.Drawing.Point(12, 28);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(782, 383);
			this.TopPanel.TabIndex = 1;
			this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
			// 
			// GetPhotoPictureBox
			// 
			this.GetPhotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GetPhotoPictureBox.Image")));
			this.GetPhotoPictureBox.Location = new System.Drawing.Point(106, 284);
			this.GetPhotoPictureBox.Name = "GetPhotoPictureBox";
			this.GetPhotoPictureBox.Size = new System.Drawing.Size(48, 43);
			this.GetPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.GetPhotoPictureBox.TabIndex = 24;
			this.GetPhotoPictureBox.TabStop = false;
			this.GetPhotoPictureBox.Click += new System.EventHandler(this.GetPhotoPictureBox_Click);
			// 
			// ClearPictureBox
			// 
			this.ClearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClearPictureBox.Image")));
			this.ClearPictureBox.Location = new System.Drawing.Point(160, 284);
			this.ClearPictureBox.Name = "ClearPictureBox";
			this.ClearPictureBox.Size = new System.Drawing.Size(48, 43);
			this.ClearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ClearPictureBox.TabIndex = 23;
			this.ClearPictureBox.TabStop = false;
			this.ClearPictureBox.Click += new System.EventHandler(this.ClearPictureBox_Click);
			// 
			// LogoPictureBox
			// 
			this.LogoPictureBox.BackColor = System.Drawing.Color.White;
			this.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LogoPictureBox.Location = new System.Drawing.Point(17, 16);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new System.Drawing.Size(300, 262);
			this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LogoPictureBox.TabIndex = 18;
			this.LogoPictureBox.TabStop = false;
			this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(377, 340);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 17);
			this.label9.TabIndex = 17;
			this.label9.Text = "Postral Code:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(376, 300);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "District Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(376, 261);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "City Name:";
			// 
			// PostralCodeTextBox
			// 
			this.PostralCodeTextBox.Location = new System.Drawing.Point(499, 340);
			this.PostralCodeTextBox.Name = "PostralCodeTextBox";
			this.PostralCodeTextBox.Size = new System.Drawing.Size(226, 23);
			this.PostralCodeTextBox.TabIndex = 7;
			// 
			// DistrictNameComboBox
			// 
			this.DistrictNameComboBox.FormattingEnabled = true;
			this.DistrictNameComboBox.Location = new System.Drawing.Point(499, 300);
			this.DistrictNameComboBox.Name = "DistrictNameComboBox";
			this.DistrictNameComboBox.Size = new System.Drawing.Size(121, 24);
			this.DistrictNameComboBox.TabIndex = 6;
			// 
			// CityNameComboBox
			// 
			this.CityNameComboBox.FormattingEnabled = true;
			this.CityNameComboBox.Location = new System.Drawing.Point(499, 261);
			this.CityNameComboBox.Name = "CityNameComboBox";
			this.CityNameComboBox.Size = new System.Drawing.Size(121, 24);
			this.CityNameComboBox.TabIndex = 5;
			// 
			// AddressLineTextBox
			// 
			this.AddressLineTextBox.Location = new System.Drawing.Point(499, 221);
			this.AddressLineTextBox.Name = "AddressLineTextBox";
			this.AddressLineTextBox.Size = new System.Drawing.Size(226, 23);
			this.AddressLineTextBox.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(377, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Address Line:";
			// 
			// WebSiteAddressTextBox
			// 
			this.WebSiteAddressTextBox.Location = new System.Drawing.Point(499, 184);
			this.WebSiteAddressTextBox.Name = "WebSiteAddressTextBox";
			this.WebSiteAddressTextBox.Size = new System.Drawing.Size(226, 23);
			this.WebSiteAddressTextBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(377, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Website Address:";
			// 
			// TelephoneTextBox
			// 
			this.TelephoneTextBox.Location = new System.Drawing.Point(499, 144);
			this.TelephoneTextBox.Name = "TelephoneTextBox";
			this.TelephoneTextBox.Size = new System.Drawing.Size(226, 23);
			this.TelephoneTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(377, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Telephone";
			// 
			// EmailAddressTextBox
			// 
			this.EmailAddressTextBox.Location = new System.Drawing.Point(499, 105);
			this.EmailAddressTextBox.Name = "EmailAddressTextBox";
			this.EmailAddressTextBox.Size = new System.Drawing.Size(226, 23);
			this.EmailAddressTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(377, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "E-Mail Address:";
			// 
			// BranchNameTextBox
			// 
			this.BranchNameTextBox.Location = new System.Drawing.Point(499, 66);
			this.BranchNameTextBox.Name = "BranchNameTextBox";
			this.BranchNameTextBox.Size = new System.Drawing.Size(226, 23);
			this.BranchNameTextBox.TabIndex = 0;
			this.BranchNameTextBox.TextChanged += new System.EventHandler(this.BranchNameTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(377, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Branch Name:";
			// 
			// LabelTopPanel
			// 
			this.LabelTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
			this.LabelTopPanel.Controls.Add(this.TopPanelLabel);
			this.LabelTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LabelTopPanel.Location = new System.Drawing.Point(0, 0);
			this.LabelTopPanel.Name = "LabelTopPanel";
			this.LabelTopPanel.Size = new System.Drawing.Size(780, 41);
			this.LabelTopPanel.TabIndex = 0;
			// 
			// TopPanelLabel
			// 
			this.TopPanelLabel.AutoSize = true;
			this.TopPanelLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TopPanelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.TopPanelLabel.Location = new System.Drawing.Point(376, 6);
			this.TopPanelLabel.Name = "TopPanelLabel";
			this.TopPanelLabel.Size = new System.Drawing.Size(161, 27);
			this.TopPanelLabel.TabIndex = 2;
			this.TopPanelLabel.Text = "MAJU School";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// BranchInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(806, 426);
			this.Controls.Add(this.TopPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "BranchInfoForm";
			this.Text = "Branch Information";
			this.Load += new System.EventHandler(this.BranchInfoForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GetPhotoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClearPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
			this.LabelTopPanel.ResumeLayout(false);
			this.LabelTopPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.Panel LabelTopPanel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox PostralCodeTextBox;
		private System.Windows.Forms.ComboBox DistrictNameComboBox;
		private System.Windows.Forms.ComboBox CityNameComboBox;
		private System.Windows.Forms.TextBox AddressLineTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox WebSiteAddressTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TelephoneTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox EmailAddressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox BranchNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label TopPanelLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.PictureBox LogoPictureBox;
		private System.Windows.Forms.PictureBox GetPhotoPictureBox;
		private System.Windows.Forms.PictureBox ClearPictureBox;
	}
}