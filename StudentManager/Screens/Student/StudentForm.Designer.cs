namespace StudentManager.Screens.Student
{
	partial class StudentForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.StudentIdTextBox = new System.Windows.Forms.TextBox();
			this.StudentNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.FatherNameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddressLineTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.CityComboBox = new System.Windows.Forms.ComboBox();
			this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(132, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student Form";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveRecordToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(437, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Enabled = false;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student ID:";
			// 
			// StudentIdTextBox
			// 
			this.StudentIdTextBox.Enabled = false;
			this.StudentIdTextBox.Location = new System.Drawing.Point(120, 99);
			this.StudentIdTextBox.Name = "StudentIdTextBox";
			this.StudentIdTextBox.Size = new System.Drawing.Size(292, 23);
			this.StudentIdTextBox.TabIndex = 3;
			// 
			// StudentNameTextBox
			// 
			this.StudentNameTextBox.Location = new System.Drawing.Point(120, 134);
			this.StudentNameTextBox.Name = "StudentNameTextBox";
			this.StudentNameTextBox.Size = new System.Drawing.Size(292, 23);
			this.StudentNameTextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Student Name:";
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(120, 206);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(292, 23);
			this.PhoneNumberTextBox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Phone Number:";
			// 
			// FatherNameTextBox
			// 
			this.FatherNameTextBox.Location = new System.Drawing.Point(120, 168);
			this.FatherNameTextBox.Name = "FatherNameTextBox";
			this.FatherNameTextBox.Size = new System.Drawing.Size(292, 23);
			this.FatherNameTextBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Father Name:";
			// 
			// AddressLineTextBox
			// 
			this.AddressLineTextBox.Location = new System.Drawing.Point(120, 347);
			this.AddressLineTextBox.Name = "AddressLineTextBox";
			this.AddressLineTextBox.Size = new System.Drawing.Size(292, 23);
			this.AddressLineTextBox.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Address Line:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 17);
			this.label7.TabIndex = 14;
			this.label7.Text = "Department:";
			// 
			// EmailAddressTextBox
			// 
			this.EmailAddressTextBox.Location = new System.Drawing.Point(120, 277);
			this.EmailAddressTextBox.Name = "EmailAddressTextBox";
			this.EmailAddressTextBox.Size = new System.Drawing.Size(292, 23);
			this.EmailAddressTextBox.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 277);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Email Address:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 241);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 17);
			this.label9.TabIndex = 10;
			this.label9.Text = "City:";
			// 
			// CityComboBox
			// 
			this.CityComboBox.FormattingEnabled = true;
			this.CityComboBox.Location = new System.Drawing.Point(120, 241);
			this.CityComboBox.Name = "CityComboBox";
			this.CityComboBox.Size = new System.Drawing.Size(292, 24);
			this.CityComboBox.TabIndex = 18;
			// 
			// DepartmentComboBox
			// 
			this.DepartmentComboBox.FormattingEnabled = true;
			this.DepartmentComboBox.Location = new System.Drawing.Point(120, 312);
			this.DepartmentComboBox.Name = "DepartmentComboBox";
			this.DepartmentComboBox.Size = new System.Drawing.Size(292, 24);
			this.DepartmentComboBox.TabIndex = 19;
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 386);
			this.Controls.Add(this.DepartmentComboBox);
			this.Controls.Add(this.CityComboBox);
			this.Controls.Add(this.AddressLineTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.EmailAddressTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.PhoneNumberTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.FatherNameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.StudentNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.StudentIdTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "StudentForm";
			this.ShowInTaskbar = true;
			this.Text = "StudentForm";
			this.Load += new System.EventHandler(this.StudentForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox CityComboBox;
		private System.Windows.Forms.ComboBox DepartmentComboBox;
		public System.Windows.Forms.TextBox StudentIdTextBox;
		public System.Windows.Forms.TextBox StudentNameTextBox;
		public System.Windows.Forms.TextBox PhoneNumberTextBox;
		public System.Windows.Forms.TextBox FatherNameTextBox;
		public System.Windows.Forms.TextBox AddressLineTextBox;
		public System.Windows.Forms.TextBox EmailAddressTextBox;
	}
}