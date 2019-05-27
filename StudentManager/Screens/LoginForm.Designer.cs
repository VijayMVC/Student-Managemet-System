namespace StudentManager.Screens
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.UserNameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SignInButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 34);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 217);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(468, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Name:";
			// 
			// UserNameTextBox
			// 
			this.UserNameTextBox.Location = new System.Drawing.Point(300, 54);
			this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.UserNameTextBox.Name = "UserNameTextBox";
			this.UserNameTextBox.Size = new System.Drawing.Size(368, 23);
			this.UserNameTextBox.TabIndex = 2;
			this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(300, 114);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '•';
			this.PasswordTextBox.Size = new System.Drawing.Size(368, 23);
			this.PasswordTextBox.TabIndex = 5;
			this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(468, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// SignInButton
			// 
			this.SignInButton.Image = ((System.Drawing.Image)(resources.GetObject("SignInButton.Image")));
			this.SignInButton.Location = new System.Drawing.Point(300, 159);
			this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(172, 92);
			this.SignInButton.TabIndex = 6;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.SignInButton.UseVisualStyleBackColor = true;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
			this.ExitButton.Location = new System.Drawing.Point(508, 159);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(160, 92);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Exit";
			this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 301);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.SignInButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UserNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "LoginForm";
			this.ShowInTaskbar = true;
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UserNameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SignInButton;
		private System.Windows.Forms.Button ExitButton;
	}
}