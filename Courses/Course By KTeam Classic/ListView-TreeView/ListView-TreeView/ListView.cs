using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_TreeView
{
	public partial class ListView : Form
	{
		public ListView()
		{
			InitializeComponent();
			
			Load();
		}

		void Load()
		{
			listView1.Columns.Add(new ColumnHeader() { Text = "Item", ImageIndex = 0, TextAlign = HorizontalAlignment.Left });
			listView1.Columns.Add(new ColumnHeader() { Text = "Creation Date" });
			listView1.Columns.Add(new ColumnHeader() { Text = "Info" });

			listView1.Items.Add(new ListViewItem() { Text = "Có súng đây nè!", ImageIndex = 0 });
			listView1.Items[0].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = DateTime.Now.ToShortDateString() });
			ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
			subItem.Text = "Chửi thề con c*t";
			subItem.BackColor = Color.Aqua;
			listView1.Items[0].SubItems.Add(subItem);

			listView1.Items.Add(new ListViewItem() { Text = "Mày tưởng tao không có súng hả?", ImageIndex = 1 });
			listView1.Items.Add(new ListViewItem() { Text = "Mày coi chừng mày chết zới tao nhan mày!", ImageIndex = 2 });
		}

		private void btnLarge_Click(object sender, EventArgs e)
		{
			listView1.View = View.LargeIcon;
		}

		private void btnSmall_Click(object sender, EventArgs e)
		{
			listView1.View = View.SmallIcon;
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			listView1.View = View.List;
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			listView1.View = View.Details;
		}
	}
}
