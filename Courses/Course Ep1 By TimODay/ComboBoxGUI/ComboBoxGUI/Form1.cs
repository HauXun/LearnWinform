using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonEnd_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Thoát chương trình!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		private void buttonDatHang_Click(object sender, EventArgs e)
		{

			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(textBoxName, "");
			errorProviderWar.SetError(textBoxNumberPhone, "");
			errorProviderWar.SetError(listBoxMatHang, "");
			errorProviderWar.SetError(groupBoxDonHang, "");
			errorProviderWar.SetError(groupBoxHinhThucTT, "");


			// Kiểm tra	họ tên không được để trống
			if (textBoxName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(textBoxName, "Họ tên không được để trống!");
				return;
			}

			// Kiểm tra	mã vùng không được để trống
			if (comboBoxRegionPhoneNumber.SelectedItem == null)
			{
				errorProviderWar.SetError(textBoxNumberPhone, "Hãy lựa chọn mã vùng");
				return;
			}

			// Kiểm tra sdt
			if (textBoxNumberPhone.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(textBoxNumberPhone, "Sdt không được để trống!");
				return;
			}
			else
			{
				ulong numberPhone;
				if (ulong.TryParse(textBoxNumberPhone.Text.Trim(), out numberPhone))
				{
					if (numberPhone.ToString().Length > 11)
					{
						errorProviderWar.SetError(textBoxNumberPhone, "Sdt không được lớn hơn 11 số!");
						return;
					}

					if (numberPhone.ToString().Length < 10)
					{
						errorProviderWar.SetError(textBoxNumberPhone, "Sdt không được nhỏ hơn 11 số!\r\n- Không bao gồm số 0");
						return;
					}
				}
				else
				{
					errorProviderWar.SetError(textBoxNumberPhone, "Hãy nhập sdt!");
					return;
				}
			}

			// Kiểm tra lựa chọn mặt hàng
			if (listBoxMatHang.SelectedIndex == -1)
			{
				errorProviderWar.SetError(groupBoxDonHang, "Hệ thống không thể xử lý nếu không lựa chọn mục mặt hàng nào");
				return;
			}

			// Kiểm tra lựa chọn hình thức thanh toán
			if (comboBoxHinhThucTT.SelectedItem == null)
			{
				errorProviderWar.SetError(groupBoxHinhThucTT, "Vui lòng chọn hình thức thanh toán");
				return;
			}

			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.Append(" Thông tin đơn hàng:\r\n");
			stringBuilder.Append($" \nHọ tên: {textBoxName.Text.Trim()}\r\n");
			stringBuilder.Append($" Số DT: {textBoxNumberPhone.Text.Trim()}\r\n");
			stringBuilder.Append("\n Mặt hàng:\r\n");

			foreach (var item in listBoxMatHang.SelectedItems)
			{
				stringBuilder.Append($"\t\t- {item}\r\n");
			}

			stringBuilder.Append($"\n Hình thức thanh toán: {comboBoxHinhThucTT.SelectedItem}");

			textBoxInfo.Text = stringBuilder.ToString();
		}

		private void comboBoxHinhThucTT_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxHinhThucTT.SelectedIndex != -1)
			{
				MessageBox.Show($"Bạn đã chọn hình thức thanh toán {comboBoxHinhThucTT.SelectedItem}",
					"Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBoxRegionPhoneNumber.Text = comboBoxRegionPhoneNumber.Items[0].ToString();
		}
	}
}
