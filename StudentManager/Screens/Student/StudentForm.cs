using SMSDBFramework;
using SMSDBFramework.Windows;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
using StudentManager.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManager.Models.Students;

namespace StudentManager.Screens.Student
{
	public partial class StudentForm : TemplateForm
	{
		public StudentForm()
		{
			InitializeComponent();
		}

		public int StudentId { get; set; }

		private void StudentForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoComboBoxes();

			if (this.IsUpdate)
			{
				LoadDataAndBindIntoControls();
			}
			else
			{
				GenerateStudentId();
			}
		}

		private void LoadDataAndBindIntoControls()
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			DataTable dtEmployee = db.GetDataList("usp_StudentGetStudentDetailsById", new DBParameter
			{
				Parameter = "@StudentId",
				Value = this.StudentId
			});

			DataRow row = dtEmployee.Rows[0];
			StudentIdTextBox.Text = row["StudentId"].ToString();
			StudentNameTextBox.Text = row["StudentName"].ToString();
			FatherNameTextBox.Text = row["FatherName"].ToString();
			PhoneNumberTextBox.Text = row["PhoneNumber"].ToString();
			CityComboBox.SelectedValue = row["CityId"];
			EmailAddressTextBox.Text = row["EmailAddress"].ToString();
			DepartmentComboBox.SelectedValue = row["DepartmentId"];
			AddressLineTextBox.Text = row["AddressLine"].ToString();


		}

		private void LoadDataIntoComboBoxes()
		{
			ListData.LoadDataIntoComboBox(CityComboBox, new DBParameter {
				Parameter = "@ListTypeId",
				Value = ListTypes.City
			});

			ListData.LoadDataIntoComboBox(DepartmentComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.Department
			});
		}

		private void GenerateStudentId()
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			StudentIdTextBox.Text = db.GetScalarValue("usp_StudentsGenerateNewStudentId").ToString();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (isFormValid())
			{
				if (this.IsUpdate)
				{
					SaveOrUpdateRecord("usp_StudentUpdateNewStudent");
					SMSMessageBox.ShowSuccessMessage("Record is updated successfully");
				}
				else
				{
					SaveOrUpdateRecord("usp_StudentAddNewStudent");
					SMSMessageBox.ShowSuccessMessage("Record is added successfully");

				}
			}
			this.Hide();
		}

		private void LoadDataIntoGridView()
		{
			DashboardForm dashboard = new DashboardForm();
			ListData.LoadDataIntoDataGridView(dashboard.StudentDataGridView, "usp_StudentGetStudent");
		}

		private void SaveOrUpdateRecord(string storedProceName)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			db.SaveOrUpdateRecord(storedProceName, GetObject());
		}

		private StudentManager.Models.Students.Student GetObject()
		{
			StudentManager.Models.Students.Student student = new StudentManager.Models.Students.Student();

			student.StudentId = Convert.ToInt32(StudentIdTextBox.Text);
			student.StudentName = StudentNameTextBox.Text.ToString();
			student.FatherName = FatherNameTextBox.Text.ToString();
			student.PhoneNumber = PhoneNumberTextBox.Text.ToString();
			student.CityId = (CityComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(CityComboBox.SelectedValue);
			student.EmailAddress = EmailAddressTextBox.Text.ToString();
			student.DepartmentId = (DepartmentComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(DepartmentComboBox.SelectedValue);
			student.AddressLine = AddressLineTextBox.Text.ToString();
			return student;
		}

		private bool isFormValid()
		{
			if (StudentNameTextBox.Text.Trim() == string.Empty) 
			{
				SMSMessageBox.ShowErrorMessage("Name is required");
				StudentNameTextBox.Focus();
				return false;
			}

			if (PhoneNumberTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Phone number is required");
				PhoneNumberTextBox.Focus();
				return false;
			}

			if (DepartmentComboBox.SelectedIndex == -1)
			{
				SMSMessageBox.ShowErrorMessage("Department is required");
				DepartmentComboBox.Focus();
				return false;
			}

			return true;
		}
	}
}
