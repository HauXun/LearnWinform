using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string str = toolStripComboBox1.SelectedItem.ToString();
			label1.Text = str;
		}

		private void cóSúngĐâyNèToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đã lựa chọn Trần Dần");
		}
	}
}
