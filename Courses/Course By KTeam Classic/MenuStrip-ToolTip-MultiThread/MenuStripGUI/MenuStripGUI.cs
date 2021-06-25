using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripGUI
{
	public partial class MenuStripGUI : Form
	{
		public MenuStripGUI()
		{
			InitializeComponent();

			//LoadMenuStrip();

			//LoadStatusBar();

			LoadAmination();
		}

		void LoadMenuStrip()
		{
			// Khởi tạo menustrip
			MenuStrip menu1 = new MenuStrip();

			ToolStripMenuItem item1 = new ToolStripMenuItem();
			item1.Text = "Có súng đây nè!";

			ToolStripMenuItem subItem1_1 = new ToolStripMenuItem();
			subItem1_1.Text = "Mày tưởng tao không có súng hả?";

			item1.DropDownItems.Add(subItem1_1);

			menu1.Items.Add(item1);

			ToolStripComboBox combo1 = new ToolStripComboBox();
			item1.DropDownItems.Add(combo1);

			ToolStripSeparator separator1 = new ToolStripSeparator();
			item1.DropDownItems.Add(separator1);

			// Thêm menustrip vào control
			this.Controls.Add(menu1);
		}

		ToolStripStatusLabel panel = new ToolStripStatusLabel();
		void LoadStatusBar()
		{
			TextBox box = new TextBox();
			this.Controls.Add(box);
			box.TextChanged += Box_TextChanged;

			StatusStrip status = new StatusStrip();
			this.Controls.Add(status);

			panel.Text = "Infomation";
			panel.AutoSize = true;
			status.Items.Add(panel);

			ToolStripStatusLabel panel2 = new ToolStripStatusLabel();
			panel2.Text = DateTime.Now.ToLongDateString();
			panel2.AutoSize = true;
			status.Items.Add(panel2);
		}

		private void Box_TextChanged(object sender, EventArgs e)
		{
			panel.Text = "Typing: " + (sender as TextBox).Text + "...";
		}

		List<PictureBox> amination = new List<PictureBox>();
		int nowShowing = 0;
		void LoadAmination()
		{
			amination.Add(pictureBox1);
			amination.Add(pictureBox2);
			amination.Add(pictureBox3);
			amination.Add(pictureBox4);
		}

		private void btnClick_Click(object sender, EventArgs e)
		{
			timer1.Start();
			timer2.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (PictureBox item in amination)
			{
				item.Visible = false;
			}
			amination[nowShowing++].Visible = true;

			if (nowShowing >= amination.Count)
			{
				nowShowing = 0;
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			ListViewItem item = new ListViewItem() { Text = "Có súng đây nè!" };
			listView1.Items.Add(item);
		}

		delegate void delegateAddItem(object o);
		private void btnCreate_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(AddItem);
			thread.Start("Tao cũng có súng đây nè!");
		}

		void AddItem(object o)
		{
			if (listView1.InvokeRequired)
			{
				this.Invoke(new delegateAddItem(AddItem), o);
			}
			else
			{
				for (int i = 0; i < 10; i++)
				{
					listView1.Items.Add(o.ToString());
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Input input = new Input();
			input.Show();
			input.FormClosed += Input_FormClosed;
			input.OkeBro += Input_OkeBro;
		}

		private void Input_OkeBro(object sender, EventArgs e)
		{
			
		}

		private void Input_FormClosed(object sender, FormClosedEventArgs e)
		{
			label1.Text = Constain.Name;
		}
	}
}
