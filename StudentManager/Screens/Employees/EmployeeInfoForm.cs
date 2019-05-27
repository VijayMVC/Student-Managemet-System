using SMSDBFramework;
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
using SMSDBFramework.Windows;
using StudentManager.Models.Employees;
using StudentManager.Models.Users;

namespace StudentManager.Screens.Employees
{
	public partial class EmployeeInfoForm : TemplateForm
	{
		public EmployeeInfoForm()
		{
			InitializeComponent();
		}

		public int EmployeeId { get; set; }

		private void EmployeeInfoForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoComboBoxes();

			if (this.IsUpdate)
			{
				LoadDataAndBindIntoControls();
				
			}
			else
			{
				GenerateEmployeeId();
				SetLeavingCommentsSection();
			}
		}

		private void SetLeavingCommentsSection()
		{
			HasLeftComboBox.Text = "No";
			EnableDisableControls(false);
		}

		private void LoadDataAndBindIntoControls()
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			DataTable dtEmployee = db.GetDataList("usp_EmployeesGetEmployeeDetailsId", new DBParameter
			{
				Parameter = "@EmployeeId",
				Value = this.EmployeeId
			});

			DataRow row = dtEmployee.Rows[0];
			EmployeeIdTextBox.Text = row["EmployeeId"].ToString();
			FullNameTextBox.Text = row["FullName"].ToString();
			DateOfBirthDateTimePicker.Value = Convert.ToDateTime(row["DateOfBirth"]);
			CNICTextBox.Text = row["CNICNumber"].ToString();
			EmailAddressTextBox.Text = row["EmailAddress"].ToString();
			MobileTextBox.Text = row["Mobile"].ToString();
			TelephoneTextBox.Text = row["Telephone"].ToString();
			GenderComboBox.SelectedValue = row["GenderId"];
			EmploymentDateDateTimePicker.Value = Convert.ToDateTime(row["EmploymentDate"]);
			BranchComboBox.SelectedValue = row["BranchId"];
			PhotoPictureBox.Image = (row["Photo"] is DBNull) ? null : ImageManipulation.PutPhoto((byte[])row["Photo"]);
			AddressLineTextBox.Text = row["AddressLine"].ToString();
			CityComboBox.SelectedValue = row["CityId"];
			DistrictComboBox.SelectedValue = row["DistrictId"];
			PostralCodeTextBox.Text = row["PostralCode"].ToString();
			JobTitleComboBox.SelectedValue = row["JobTitleId"];
			CurrentSalaryTextBox.Text = row["CurrentSalary"].ToString();
			StartingSalaryTextBox.Text = row["StartingSalary"].ToString();
			HasLeftComboBox.Text = (Convert.ToBoolean(row["HasLeft"]) == true) ? "Yes" : "No";
			if (row["DateLeft"] is DBNull) { DateLeftDateTimePicker.CustomFormat = " "; }
			else { DateLeftDateTimePicker.Value = Convert.ToDateTime(row["DateLeft"]); }
			
			ReasonLeftComboBox.SelectedValue = row["ReasonLeftId"];
			CommentsTextBox.Text = row["Comments"].ToString();

		}

		private void LoadDataIntoComboBoxes()
		{
			ListData.LoadDataIntoComboBox(CityComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.City
			});

			ListData.LoadDataIntoComboBox(DistrictComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.District
			});

			ListData.LoadDataIntoComboBox(GenderComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.Gender
			});

			ListData.LoadDataIntoComboBox(JobTitleComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.EmployeeJobTitle
			});

			ListData.LoadDataIntoComboBox(HasLeftComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.YesNo
			});

			ListData.LoadDataIntoComboBox(ReasonLeftComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.EmployeeReasonLeft
			});

			ListData.LoadDataIntoComboBox(BranchComboBox, "usp_BranchesGetAllBrancheNames");
		}

		private void GenerateEmployeeId()
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			EmployeeIdTextBox.Text = db.GetScalarValue("usp_EmployeesGenerateNewEmployeeId").ToString();

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PhotoPictureBox_Click(object sender, EventArgs e)
		{

		}

		private void PhotoPictureBox_DoubleClick(object sender, EventArgs e)
		{
			GetPhoto();
		}

		private void GetPhoto()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Select Photo";
			ofd.Filter = "Photo File (*.png;*.jpg;*.bmp;*gif)|*.png;*.jpg;*.bmp;*gif";
			ofd.ShowDialog();

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				PhotoPictureBox.Image = new Bitmap(ofd.FileName);
			}
		}

		private void GetPhotoPictureBox_Click(object sender, EventArgs e)
		{
			GetPhoto();
		}

		private void ClearPictureBox_Click(object sender, EventArgs e)
		{
			PhotoPictureBox.Image = null;
		}

		private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (isFormValid())
			{
				if (IsUpdate)
				{
					SaveOrUpdateRecord("usp_EmployeesUpdateEmployeeDetails");
					SMSMessageBox.ShowSuccessMessage("Record is updated successfully");
				}
				else
				{
					SaveOrUpdateRecord("usp_EmployeesAddNewEmployee");
					SMSMessageBox.ShowSuccessMessage("Record is added successfully");
					this.IsUpdate = true;
					
				}
				this.Close();
			}
		}

	

		private void SaveOrUpdateRecord(string storeProceName)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			db.SaveOrUpdateRecord(storeProceName, GetObject());
		}

		private Employee GetObject()
		{
			Employee employee = new Employee();
			employee.EmployeeId = Convert.ToInt32(EmployeeIdTextBox.Text);
			employee.FullName = FullNameTextBox.Text.Trim();
			employee.DateOfBirth = DateOfBirthDateTimePicker.Value.Date;
			employee.CNICNumber = CNICTextBox.Text.Trim();
			employee.EmailAddress = EmailAddressTextBox.Text.Trim();
			employee.Mobile = MobileTextBox.Text.Trim();
			employee.Telephone = TelephoneTextBox.Text.Trim();
			employee.EmploymentDate = EmploymentDateDateTimePicker.Value.Date;
			employee.GenderId = (GenderComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(GenderComboBox.SelectedValue);
			employee.BranchId = (BranchComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(BranchComboBox.SelectedValue);

			employee.Photo = (PhotoPictureBox.Image == null) ? null : ImageManipulation.GetPhoto(PhotoPictureBox);

			employee.AddressLine = AddressLineTextBox.Text.Trim();
			employee.CityId = (CityComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(CityComboBox.SelectedValue);
			employee.DistrictId = (DistrictComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(DistrictComboBox.SelectedValue);
			employee.PostralCode = Convert.ToInt32(PostralCodeTextBox.Text.Trim());

			employee.JobTitleId = (JobTitleComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(JobTitleComboBox.SelectedValue);
			employee.CurrentSalary = Convert.ToDecimal(CurrentSalaryTextBox.Text);
			employee.StartingSalary = Convert.ToDecimal(StartingSalaryTextBox.Text);

			employee.HasLeft = (HasLeftComboBox.Text == "Yes") ? true : false;
			employee.DateLeft = (HasLeftComboBox.Text == "Yes") ? DateLeftDateTimePicker.Value.Date : (DateTime?) null;
			employee.ReasonLeftId = (ReasonLeftComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(ReasonLeftComboBox.SelectedValue);
			employee.Comments = CommentsTextBox.Text.Trim();
			employee.CreatedBy = LoggedInUser.UserName;

			return employee;
		}

		private bool isFormValid()
		{

			if (FullNameTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Full Name is required");
				FullNameTextBox.Focus();
				return false;
			}

			if (DateOfBirthDateTimePicker.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Date of Birth is required");
				DateOfBirthDateTimePicker.Focus();
				return false;
			}

			if (CNICTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("CNIC is required");
				FullNameTextBox.Focus();
				return false;
			}

			if ((MobileTextBox.Text.Trim() == string.Empty) && (TelephoneTextBox.Text.Trim() == string.Empty))
			{
				SMSMessageBox.ShowErrorMessage("Mobile or Telephone number is required");
				MobileTextBox.Focus();
				return false;
			}

			if (GenderComboBox.SelectedIndex == -1)
			{
				SMSMessageBox.ShowErrorMessage("Gender is required");
				return false;
			}

			if (EmploymentDateDateTimePicker.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Employment Date is required");
				EmploymentDateDateTimePicker.Focus();
				return false;
			}

			if (AddressLineTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Address Line is required");
				AddressLineTextBox.Focus();
				return false;
			}

			if (CityComboBox.SelectedIndex == -1)
			{
				SMSMessageBox.ShowErrorMessage("City is required");
				return false;
			}

			if (DistrictComboBox.SelectedIndex == -1)
			{
				SMSMessageBox.ShowErrorMessage("District is required");
				return false;
			}

			if (PostralCodeTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Postral code is required");
				PostralCodeTextBox.Focus();
				return false;
			}

			if (JobTitleComboBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Job Title is required");
				JobTitleComboBox.Focus();
				return false;
			}

			if (CurrentSalaryTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Current Salary is required");
				CurrentSalaryTextBox.Focus();
				return false;
			}
			else
			{
				if (Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim()) < 1)
				{
					SMSMessageBox.ShowErrorMessage("Current Salary can not be zero or less than zero");
					CurrentSalaryTextBox.Focus();
					return false;
				}
			}

			if (StartingSalaryTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Starting Salary is required");
				StartingSalaryTextBox.Focus();
				return false;
			}
			else
			{
				if (Convert.ToDecimal(StartingSalaryTextBox.Text.Trim()) < 1)
				{
					SMSMessageBox.ShowErrorMessage("Starting Salary can not be zero or less than zero");
					StartingSalaryTextBox.Focus();
					return false;
				}
			}

			if (HasLeftComboBox.Text == "Yes")
			{
				if (DateLeftDateTimePicker.Text.Trim() == string.Empty)
				{
					SMSMessageBox.ShowErrorMessage("Date Left is required");
					DateLeftDateTimePicker.Focus();
					return false;
				}

				if (ReasonLeftComboBox.Text.Trim() == string.Empty)
				{
					SMSMessageBox.ShowErrorMessage("Leaving reason is required");
					ReasonLeftComboBox.Focus();
					return false;
				}

				if (CommentsTextBox.Text.Trim() == string.Empty)
				{
					SMSMessageBox.ShowErrorMessage("Leaving Comments are required");
					CommentsTextBox.Focus();
					return false;
				}


			}
			return true;
		}

		private void FullNameTextBox_TextChanged(object sender, EventArgs e)
		{
			TopPanelLabel.Text = FullNameTextBox.Text;
		}

		private void HasLeftComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (HasLeftComboBox.Text == "No")
			{
				DateLeftDateTimePicker.CustomFormat = " ";
				ReasonLeftComboBox.SelectedIndex = -1;
				EnableDisableControls(false);
			}
			
			if (HasLeftComboBox.Text == "No")
			{
				EnableDisableControls(true);
			}
		}

		private void EnableDisableControls(bool enable)
		{
			DateLeftDateTimePicker.Enabled = enable;
			ReasonLeftComboBox.Enabled = enable;
			CommentsTextBox.Enabled = enable;
		}
	}
}
