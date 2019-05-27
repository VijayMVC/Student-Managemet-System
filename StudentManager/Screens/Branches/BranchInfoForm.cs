using SMSDBFramework;
using SMSDBFramework.Windows;
using StudentManager.Models.Branches;
using StudentManager.Models.Users;
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

namespace StudentManager.Screens.Branches
{
	public partial class BranchInfoForm : TemplateForm
	{
		public BranchInfoForm()
		{
			InitializeComponent();
		}

		private void BranchInfoForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoComboBoxes();
		    LoadDataAndBindToControlIfUpdate();
		}

		private void LoadDataIntoComboBoxes()
		{
			ListData.LoadDataIntoComboBox(CityNameComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.City
			});

			ListData.LoadDataIntoComboBox(DistrictNameComboBox, new DBParameter
			{
				Parameter = "@ListTypeId",
				Value = ListTypes.District
			});
		}

		private void LoadDataAndBindToControlIfUpdate()
		{
			if (this.IsUpdate)
			{
				DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
				DBParameter para = new DBParameter();
				para.Parameter = "@BranchId";
				para.Value = this.BranchId;
				DataTable dtBranch = db.GetDataList("usp_BranchesGetBranchDetailByBranchId", para);
				DataRow row = dtBranch.Rows[0];

				BranchNameTextBox.Text = row["BranchName"].ToString();
				EmailAddressTextBox.Text = row["Email"].ToString();
				TelephoneTextBox.Text = row["Telephone"].ToString();
				WebSiteAddressTextBox.Text = row["WebSite"].ToString();
				AddressLineTextBox.Text = row["AddressLine"].ToString();
				CityNameComboBox.SelectedValue = row["CityId"];
				DistrictNameComboBox.SelectedValue = row["DistrictId"];
				PostralCodeTextBox.Text = row["PostralCode"].ToString();
				LogoPictureBox.Image = (row["branchImage"]is DBNull ) ? null : ImageManipulation.PutPhoto((byte[])row["branchImage"]);

			}
		}

		public int BranchId { get; set; }

		

		private void BranchNameTextBox_TextChanged(object sender, EventArgs e)
		{
			TopPanelLabel.Text = BranchNameTextBox.Text;
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
			GetPhoto();

		}

		private void GetPhoto()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Select Logo";
			ofd.Filter = "Logo File (*.png;*.jpg;*.bmp;*gif)|*.png;*.jpg;*.bmp;*gif";
			ofd.ShowDialog();

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				LogoPictureBox.Image = new Bitmap(ofd.FileName);
			}
		}

		private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (isFormValid())
			{
				if (this.IsUpdate)
				{
					SaveOrUpdateRecord("usp_BranchesUpdateBranchDetails");
					SMSMessageBox.ShowSuccessMessage("Record is updated successfully");
				}
				else
				{
					SaveOrUpdateRecord("usp_BranchesAddNewBranch");
					SMSMessageBox.ShowSuccessMessage("Record is added successfully");
				}
				this.Close();
			}

		}

		private bool isFormValid()
		{
			if (BranchNameTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Branch Name is required");
				BranchNameTextBox.Focus();
				return false;
			}

			if (EmailAddressTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Email is required");
				EmailAddressTextBox.Focus();
				return false;
			}

			if (TelephoneTextBox.Text.Trim() == string.Empty)
			{
				SMSMessageBox.ShowErrorMessage("Telephone is required");
				TelephoneTextBox.Focus();
				return false;
			}

			return true;
		}

		
		private void SaveOrUpdateRecord(string storedProcName)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			db.SaveOrUpdateRecord(storedProcName, GetObject());
		}

		private Branch GetObject()
		{
			Branch branch = new Branch();
			branch.BranchId = (this.IsUpdate) ? this.BranchId : 0;
			branch.BranchName = BranchNameTextBox.Text;
			branch.Email = EmailAddressTextBox.Text;
			branch.Telephone = TelephoneTextBox.Text;
			branch.Website = WebSiteAddressTextBox.Text;
			branch.AddressLine = AddressLineTextBox.Text;
			branch.CityId = Convert.ToInt32(CityNameComboBox.SelectedValue);
			branch.DistrictId = Convert.ToInt32(DistrictNameComboBox.SelectedValue);
			branch.PostralCode = Convert.ToInt32(PostralCodeTextBox.Text);
			branch.CreatedBy = LoggedInUser.UserName;
			branch.BranchImage = (LogoPictureBox.Image == null) ? null : ImageManipulation.GetPhoto(LogoPictureBox);

			return branch;
		}

		private void TopPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void GetPhotoPictureBox_Click(object sender, EventArgs e)
		{
			GetPhoto();
		}

		private void ClearPictureBox_Click(object sender, EventArgs e)
		{
			LogoPictureBox.Image = null;
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
