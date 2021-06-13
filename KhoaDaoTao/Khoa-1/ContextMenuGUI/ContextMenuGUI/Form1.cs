using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuGUI
{
	public partial class Form1 : Form
	{
		ContextMenuStrip contextMenu;
		public Form1()
		{
			InitializeComponent();

			contextMenu = new ContextMenuStrip();

			ToolStripButton stripButton = new ToolStripButton() { Text = "Lấy súng" , AutoSize = true};
			stripButton.Click += StripButton_Click;
			contextMenu.Items.Add(stripButton);
		}

		private void StripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show((sender as ToolStripItem).Text);
			MessageBox.Show("Có súng đây nè!", "Đã lấy súng!");
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			//contextMenuStrip1.Show(textBox1, new Point(50, 50), ToolStripDropDownDirection.AboveRight);
			//textBox1.ContextMenuStrip.Show(textBox1, new Point(50, 50), ToolStripDropDownDirection.AboveRight);
			contextMenu.Show(this, this.PointToClient(MousePosition));
		}
	}
}
