using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
	public partial class Ex3 : Form
	{
		public Ex3()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string username = textBoxUsername.Text.Trim();
			string password = textBoxPassword.Text.Trim();

			if (string.Compare(username, "admin", true) == 0 
				&& password.Equals("admin"))
			{
				MessageBox.Show("Đăng nhập thành công!");
			}	
			else
			{
				MessageBox.Show("Đăngn nhập thất bại!");
			}	
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Thoát chương trình!", "Close!",
				MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
