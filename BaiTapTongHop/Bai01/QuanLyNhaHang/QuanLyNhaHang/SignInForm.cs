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
	public partial class SignInForm : Form
	{
		public SignInForm()
		{
			InitializeComponent();
		}

		string id = "admin";
		string password = "admin";

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbName, "");
			errorProviderWar.SetError(tbPassword, "");

			// Kiểm tra	tài khoản không được để trống
			if (tbName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbName, "Tài khoản không được để trống!");
				return;
			}

			// Kiểm tra	mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống");
				return;
			}

			// Nếu đăng nhập đúng
			if (ValidateDangNhap(tbName.Text, tbPassword.Text))
			{
				// Mở form
				MainForm form = new MainForm();
				form.Show();
				form.DangXuat += Form_DangXuat;

				// Xóa dữ liệu các textBox
				ClearTextBox();

				//this.Visible = false;
				this.Hide();
			}	
			else
			{
				// Sai tài khoản hoặc mật khẩu
				if (!ValidateDangNhap(tbName.Text, tbPassword.Text))
				{
					errorProviderWar.SetError(tbPassword, "Sai tài khoản hoặc mặt khẩu");
					return;
				}
			}	
		}

		private void Form_DangXuat(object sender, EventArgs e)
		{
			(sender as MainForm).isShowing = false;
			(sender as MainForm).Close();
			this.Show();
		}

		/// <summary>
		/// Kiểm tra xem có đăng nhập được hay không
		/// Đúng: Mở form main -> Ẩn form đăng nhập
		/// Sai: Kiểm tra tài khoản mật khẩu
		/// </summary>
		/// <param name="id"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		bool ValidateDangNhap(string id, string password)
		{
			if (id.Equals(this.id) && password.Equals(this.password))
				return true;
			return false;
		}

		/// <summary>
		/// Clear dữ liệu của các textBox
		/// </summary>
		void ClearTextBox()
		{
			foreach (var item in this.Controls)
			{
				if (item is TextBox && item != null)
				{
					(item as TextBox).Clear();
				}	
			}
			tbName.Focus();
		}

		/// <summary>
		/// Thoát chương trình hoàn toàn
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
