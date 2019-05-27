﻿using StudentManager.Screens.Templates;
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

namespace StudentManager.Screens.Employees
{
	public partial class ManageEmployeesForm : TemplateForm
	{
		public ManageEmployeesForm()
		{
			InitializeComponent();
		}

		private void ManageEmployeesForm_Load(object sender, EventArgs e)
		{
			LoadDataIntoDataGridView();
		}

		private void LoadDataIntoDataGridView()
		{
			ListData.LoadDataIntoDataGridView(EmployeesDataGridView, "usp_EmployeesGetEmployees");
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowEmployeeInfoScreen(0, false);
		}

		private void ShowEmployeeInfoScreen(int employeeId, bool isUpdate)
		{
			EmployeeInfoForm eif = new EmployeeInfoForm();
			eif.EmployeeId = employeeId;
			eif.IsUpdate = isUpdate;
			eif.ShowDialog();

			LoadDataIntoDataGridView();
		}

		private void EmployeesDataGridView_DoubleClick(object sender, EventArgs e)
		{
			int rowIndex = EmployeesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			int employeeId = Convert.ToInt32(EmployeesDataGridView.Rows[rowIndex].Cells["EmployeeId"].Value);
			ShowEmployeeInfoScreen(employeeId, true);
		}

		private void EmployeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
