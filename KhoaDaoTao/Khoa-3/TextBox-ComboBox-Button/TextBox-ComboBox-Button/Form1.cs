using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ComboBox_Button
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 1; i <= 31; i++)
			{
				comboBoxDay.Items.Add(i);
			}
			comboBoxDay.SelectedIndex = 0;

			for (int i = 1; i <= 12; i++)
			{
				comboBoxMonth.Items.Add(i);
			}
			comboBoxMonth.SelectedIndex = 0;

			for (int i = 1930; i <= 2010; i++)
			{
				comboBoxYear.Items.Add(i);
			}
			comboBoxYear.SelectedIndex = 0;
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			// Tháng sinh hợp lệ có 30 ngày: 4 - 6 - 9 - 11
			// Năm không nhuận có 28 ngày
			// Còn lại 31 ngày

			byte ngay = byte.Parse(comboBoxDay.SelectedItem.ToString());
			byte thang = byte.Parse(comboBoxMonth.SelectedItem.ToString());
			int nam = int.Parse(comboBoxYear.SelectedItem.ToString());

			switch (thang)
			{
				case 4:
				case 6:
				case 9:
				case 11:
					if (ngay > 30)
					{
						MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi Tháng!",
							MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						MessageBox.Show($"{textBoxName.Text}: {ngay}/{thang}/{nam} hợp lệ!",
							"Kiểm tra năm sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;
				case 2:
					if (((nam % 4 == 0) && (nam % 100 != 0)) || nam % 400 == 0)
					{
						// Đây là năm nhuận
						if (ngay > 29)
						{
							MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi Năm Nhuận!",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							MessageBox.Show($"{textBoxName.Text}: {ngay}/{thang}/{nam} hợp lệ!",
								"Kiểm tra năm sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						if (ngay > 28)
						{
							MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi Tháng!",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							MessageBox.Show($"{textBoxName.Text}: {ngay}/{thang}/{nam} hợp lệ!",
								"Kiểm tra năm sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					break;
				default:
					if (ngay > 31)
					{
						MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi Ngày!",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						MessageBox.Show($"{textBoxName.Text}: {ngay}/{thang}/{nam} hợp lệ!",
							"Kiểm tra năm sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;
			}
		}
	}
}
