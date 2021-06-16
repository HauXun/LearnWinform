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

		private void buttonInput_Click(object sender, EventArgs e)
		{
			// Lấy ra số trong textBox
			double number;

			if (double.TryParse(textBoxInput.Text.Trim(), out number))
			{
				// Thêm số vào listBox
				listBoxNumber.Items.Add(number);

				// Xóa đi text đã nhập
				textBoxInput.Clear();
			}
		}

		private void buttonSum_Click(object sender, EventArgs e)
		{
			int n = listBoxNumber.Items.Count;
			double sum = 0;

			for (int i = 0; i < n; i++)
			{
				sum += (double)listBoxNumber.Items[i];
			}

			MessageBox.Show("Tổng các phần tử trên danh sách là >> " + sum);
		}

		private void buttonRemoveHeadTail_Click(object sender, EventArgs e)
		{
			listBoxNumber.Items.RemoveAt(0);
			listBoxNumber.Items.RemoveAt(listBoxNumber.Items.Count - 1);
		}

		private void buttonRemoveSelected_Click(object sender, EventArgs e)
		{
			while (listBoxNumber.SelectedIndices.Count > 0)
				listBoxNumber.Items.RemoveAt(listBoxNumber.SelectedIndices[0]);

			//int n = listBoxNumber.SelectedIndices.Count;
			//for (int i = 0; i < n; i++)
			//{
			//	int j = listBoxNumber.SelectedIndices[0];
			//	listBoxNumber.Items.RemoveAt(j);
			//}
		}

		private void buttonIncreaseTwice_Click(object sender, EventArgs e)
		{
			int n = listBoxNumber.Items.Count;
			for (int i = 0; i < n; i++)
			{
				listBoxNumber.Items[i] = 2 + (double)listBoxNumber.Items[i];
			}
		}

		private void buttonChangeWithDouble_Click(object sender, EventArgs e)
		{
			int n = listBoxNumber.Items.Count;
			for (int i = 0; i < n; i++)
			{
				listBoxNumber.Items[i] = Math.Pow((double)listBoxNumber.Items[i], 2);
			}
		}

		private void buttonGetEvenNumber_Click(object sender, EventArgs e)
		{
			// Bỏ check item
			//listBoxNumber.SelectedIndex = -1;

			listBoxNumber.SelectedItem = null;

			int n = listBoxNumber.Items.Count;
			for (int i = 0; i < n; i++)
			{
				if ((double)listBoxNumber.Items[i] % 2 == 0)
				{
					//listBoxNumber.SelectedIndex = i;
					listBoxNumber.SelectedItem = listBoxNumber.Items[i];
				}	
			}
		}

		private void buttonGetOddNumber_Click(object sender, EventArgs e)
		{
			// Bỏ check item
			listBoxNumber.SelectedIndex = -1;

			int n = listBoxNumber.Items.Count;
			for (int i = 0; i < n; i++)
			{
				if ((double)listBoxNumber.Items[i] % 2 != 0)
				{
					listBoxNumber.SelectedIndex = i;
				}
			}
		}

		private void buttonEnd_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Thoát chương trình!",
				"Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}	
		}
	}
}
