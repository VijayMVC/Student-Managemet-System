using SMSDBFramework;
using SMSDBFramework.Windows;
using StudentManager.Screens.Branches;
using StudentManager.Screens.Employees;
using StudentManager.Screens.Student;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
using StudentManager.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens
{
	public partial class DashboardForm : TemplateForm
	{
		
		public DashboardForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Application.Exit();
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
		}

		private void ManageBranchesToolStripButton_Click(object sender, EventArgs e)
		{
			ManageBranchesForm mbf = new ManageBranchesForm();
			mbf.ShowDialog();
		}

		private void ManageEmployeesToolStripButton_Click(object sender, EventArgs e)
		{
			ManageEmployeesForm mef = new ManageEmployeesForm();
			mef.ShowDialog();
		}

		private void NewStudentToolStripButton_Click(object sender, EventArgs e)
		{
			ShowStudentInfoScreen(0, false);
		}

		private void ShowStudentInfoScreen(int studentId, bool isUpdate)
		{
			StudentForm sf = new StudentForm();
			sf.StudentId = studentId;
			sf.IsUpdate = isUpdate;
			sf.ShowDialog();
			LoadDataIntoGridView();

		}

		private void CloseToolStripButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
		}

		private void DashboardForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoGridView();
		}

		private void LoadDataIntoGridView()
		{
			ListData.LoadDataIntoDataGridView(StudentDataGridView, "usp_StudentGetStudent");
		}

		private void StudentDataGridView_DoubleClick(object sender, EventArgs e)
		{
			int rowIndex = StudentDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			int studentId = Convert.ToInt32(StudentDataGridView.Rows[rowIndex].Cells["StudentId"].Value);
		    ShowStudentInfoScreen(studentId, true);
		}

		
		private void DeleteRecordToolStripButton_Click(object sender, EventArgs e)
		{

			int rowIndex = StudentDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			
			SqlDataReader dataReader;
			try
			{
				if (rowIndex != -1)
				{
					int StudentId = Convert.ToInt32(StudentDataGridView.Rows[rowIndex].Cells["StudentId"].Value);

					string query = "DELETE FROM dbo.Student WHERE StudentId='" + StudentId + "';";
					SqlConnection Sqlcon = new SqlConnection(AppSetting.ConnectionString());
					SqlCommand SqlCom = new SqlCommand(query, Sqlcon);
					Sqlcon.Open();
					dataReader = SqlCom.ExecuteReader();
					SMSMessageBox.ShowSuccessMessage("Row Deleted");
					while (dataReader.Read()) { }
					LoadDataIntoGridView();

				}
				else
				{
					SMSMessageBox.ShowErrorMessage("Please Select Row");
				}

			}
			catch (Exception ex)
			{

				SMSMessageBox.ShowErrorMessage("Error Message");
			}
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{

		}

		SqlConnection Sqlcon;

		private void SearchTextBox_TextChanged(object sender, EventArgs e)
		{
			Sqlcon = new SqlConnection(AppSetting.ConnectionString());
			string query = "SELECT * FROM dbo.Student WHERE StudentName LIKE'" + SearchTextBox.Text + "%'";
			
			Sqlcon.Open();
			SqlCommand SqlCom = new SqlCommand(query, Sqlcon);
			
			SqlDataAdapter adp = new SqlDataAdapter(SqlCom);
			DataTable dt = new DataTable();
			adp.Fill(dt);
			StudentDataGridView.DataSource = dt;
		}

		private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
