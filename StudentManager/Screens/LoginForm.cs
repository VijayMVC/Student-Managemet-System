using SMSDBFramework;
using SMSDBFramework.Windows;
using StudentManager.Models.Users;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens
{
	public partial class LoginForm : TemplateForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void SignInButton_Click(object sender, EventArgs e)
		{
			if (isFormValid())
			{
				DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
				bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameter()));
				if (isLoginDetailsCorrect)
				{
					GetLoggedInUserSetting();
					this.Hide();
					DashboardForm df = new DashboardForm();
					df.Show();
				}
				else
				{
					SMSMessageBox.ShowErrorMessage("User name/Password is not correct");
				}
				
			}
			
		}

		private void GetLoggedInUserSetting()
		{
			LoggedInUser.UserName = UserNameTextBox.Text.Trim();
		}

		private DBParameter[] GetParameter()
		{
			List<DBParameter> parameters = new List<DBParameter>();
			DBParameter dbparam1 = new DBParameter();
			dbparam1.Parameter = "@UserName";
			dbparam1.Value = UserNameTextBox.Text;
			parameters.Add(dbparam1);

			DBParameter dbparam2 = new DBParameter();
			dbparam2.Parameter = "@Password";
			dbparam2.Value = PasswordTextBox.Text;
			parameters.Add(dbparam2);


			return parameters.ToArray();
		}

		private bool isFormValid()
		{
			if (UserNameTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("User name is not correct");
				UserNameTextBox.Clear();
				UserNameTextBox.Focus();
				return false;
			}

			if (PasswordTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Password is not correct");
				PasswordTextBox.Clear();
				PasswordTextBox.Focus();
				return false;
			}

			return true;		
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
