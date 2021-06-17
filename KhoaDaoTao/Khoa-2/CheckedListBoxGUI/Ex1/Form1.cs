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

		private void buttonXem_Click(object sender, EventArgs e)
		{
			int n = checkedListBoxDanhSach.CheckedItems.Count;

			if (n > 0)
			{
				int stt = 0;
				listViewDanhSachChon.Items.Clear();
				for (int i = 0; i < n; i++)
				{
					ListViewItem listView = new ListViewItem((++stt).ToString());
					listView.SubItems.Add(checkedListBoxDanhSach.CheckedItems[i].ToString());

					// Thêm từng dòng dữ liệu vào listView
					listViewDanhSachChon.Items.Add(listView);
				}
			}	
		}
	}
}
