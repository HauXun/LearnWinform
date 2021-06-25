using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadListView();
		}

		ImageList imageListSmall;
		ImageList imageListLarge;

		void LoadImageList()
		{
			imageListLarge = new ImageList() { ImageSize = new Size(86, 64) };

			imageListLarge.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\15yearsdefqon.png"));
			imageListLarge.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\PowerHour.png"));
			imageListLarge.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\SundayFunday.png"));

			imageListSmall = new ImageList() { ImageSize = new Size(24, 16) };

			imageListSmall.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\15yearsdefqon.png"));
			imageListSmall.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\PowerHour.png"));
			imageListSmall.Images.Add(new Bitmap(Application.StartupPath +
				"\\Images\\SundayFunday.png"));
		}

		void LoadListView()
		{
			LoadImageList();

			listViewShow.FullRowSelect = true;
			listViewShow.GridLines = true;

			listViewShow.LargeImageList = imageListLarge;
			listViewShow.SmallImageList = imageListSmall;

			listViewShow.Columns.Add("Column 1");
			listViewShow.Columns.Add("Column 2");
			listViewShow.Columns.Add("Column 3");

			ListViewItem item = new ListViewItem();
			item.Text = "Item 1";
			item.ImageIndex = 0;
			item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I1" });
			item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I2" });

			ListViewItem item2 = new ListViewItem();
			item2.Text = "Item 2";
			item2.ImageIndex = 1;
			item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I1" });
			item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I2" });

			ListViewItem item3 = new ListViewItem();
			item3.Text = "Item 3";
			item3.ImageIndex = 2;
			item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I1" });
			item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub I2" });

			listViewShow.Items.Add(item);
			listViewShow.Items.Add(item2);
			listViewShow.Items.Add(item3);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listViewShow.View = View.LargeIcon;
			listViewShow.CheckBoxes = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listViewShow.View = View.Details;
			listViewShow.CheckBoxes = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listViewShow.View = View.SmallIcon;
			listViewShow.CheckBoxes = false;
		}

		private void listViewShow_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView listView = sender as ListView;

			if (listView.SelectedItems.Count > 0)
			{
				//ListViewItem item = listView.SelectedItems[0];

				foreach (ListViewItem item in listView.SelectedItems)
				{
					MessageBox.Show(item.Text);
				}
			}	
		}
	}
}
