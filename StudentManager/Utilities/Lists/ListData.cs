using SMSDBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Utilities.Lists
{
	public class ListData
	{
		public static object BranchesDataGridView { get; private set; }

		public static void LoadDataIntoDataGridView(DataGridView dgv, string storedProceName)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			dgv.DataSource = db.GetDataList(storedProceName);
			dgv.MultiSelect = false;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		public static void LoadDataIntoComboBox(ComboBox cb, DBParameter parameter)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			cb.DataSource = db.GetDataList("usp_ListTypesDataGetDataByListTypeId", parameter);
			cb.DisplayMember = "Description";
			cb.ValueMember = "Id";
			cb.SelectedIndex = -1;
			cb.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public static void LoadDataIntoComboBox(ComboBox cb, string storedProceName, DBParameter parameter)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			cb.DataSource = db.GetDataList(storedProceName, parameter);
			cb.DisplayMember = "Description";
			cb.ValueMember = "Id";
			cb.SelectedIndex = -1;
			cb.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public static void LoadDataIntoComboBox(ComboBox cb, string storedProceName)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			cb.DataSource = db.GetDataList(storedProceName);
			cb.DisplayMember = "Description";
			cb.ValueMember = "Id";
			cb.SelectedIndex = -1;
			cb.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public static void LoadDataIntoComboBox(ComboBox cb, string storedProceName, DBParameter[] parameters)
		{
			DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
			cb.DataSource = db.GetDataList(storedProceName, parameters);
			cb.DisplayMember = "Description";
			cb.ValueMember = "Id";
			cb.SelectedIndex = -1;
			cb.DropDownStyle = ComboBoxStyle.DropDownList;
		}
	}
}
