using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSDBFramework.Windows
{
	public class SMSMessageBox
	{
		public static void ShowErrorMessage(string Message)
		{
			MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowErrorMessage(string Message, string title)
		{
			MessageBox.Show(Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowSuccessMessage(string Message)
		{
			MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void ShowSuccessMessage(string Message, string title)
		{
			MessageBox.Show(Message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}
}
