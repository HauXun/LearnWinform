using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Button
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonPutOne_Click(object sender, EventArgs e)
		{
			if (listBoxMatHang.SelectedItems.Count > 0)
			{
				// Di chuyển Item từ listBox1 sang listBox2
				listBoxSelected.Items.Add(listBoxMatHang.SelectedItem);

				// Bỏ đi Item đã Add bên listBox1
				listBoxMatHang.Items.Remove(listBoxMatHang.SelectedItem);
			}	
		}

		private void buttonPutAll_Click(object sender, EventArgs e)
		{
			int n = listBoxMatHang.Items.Count;
			for (int i = 0; i < n; i++)
			{
				listBoxSelected.Items.Add(listBoxMatHang.Items[0]);

				// Remove các Item của listBox1
				listBoxMatHang.Items.Remove(listBoxMatHang.Items[0]);
			}
		}

		private void buttonRemoveOne_Click(object sender, EventArgs e)
		{
			if (listBoxSelected.SelectedItems.Count > 0)
			{
				// Di chuyển Item từ listBox1 sang listBox2
				listBoxMatHang.Items.Add(listBoxSelected.SelectedItem);

				// Bỏ đi Item đã Add bên listBox1
				listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
			}
		}

		private void buttonRemoveAll_Click(object sender, EventArgs e)
		{
			int n = listBoxSelected.Items.Count;
			for (int i = 0; i < n; i++)
			{
				listBoxMatHang.Items.Add(listBoxSelected.Items[0]);

				// Remove các Item của listBox1
				listBoxSelected.Items.Remove(listBoxSelected.Items[0]);
			}
		}
	}
}
