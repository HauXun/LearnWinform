using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(textBoxName, "");
			errorProviderWar.SetError(textBoxAge, "");
			errorProviderWar.SetError(dateTimePickerReg, "");

			// Kiểm tra	họ tên không được để trống
			if (textBoxName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(textBoxName, "Họ tên không được để trống!");
				return;
			}	

			// Kiểm tra tuổi phải lớn hơn 17
			if (textBoxAge.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(textBoxAge, "Tuổi không được để trống!");
				return;
			}
			else
			{
				int age;
				if (int.TryParse(textBoxAge.Text.Trim(), out age))
				{
					if (age < 18)
					{
						errorProviderWar.SetError(textBoxAge, "Tuổi không được nhỏ hơn 18!");
						return;
					}
				}
				else
				{
					errorProviderWar.SetError(textBoxAge, "Hãy nhập tuổi!");
					return;
				}
			}

			// Kiểm tra ngày đăng ký không vào ngày chủ nhật
			if (dateTimePickerReg.Value.DayOfWeek.Equals(DayOfWeek.Sunday))
			{
				errorProviderWar.SetError(dateTimePickerReg, "Không được đăng ký vào ngày chủ nhật");
				return;
			}

			MessageBox.Show("Đăng ký thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
