using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Cho biết form có đang Show hay không
		/// </summary>
		public bool isShowing = true;

		/// <summary>
		/// Event thông báo đăng xuất
		/// </summary>
		public event EventHandler DangXuat;

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			DangXuat(this, new EventArgs());
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			CloseForm();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			CloseForm();
		}

		/// <summary>
		/// Đóng form hiện tại
		/// </summary>
		void CloseForm()
		{
			if (isShowing)
			{
				isShowing = false;
				Application.Exit();
			}	
		}
	}
}
