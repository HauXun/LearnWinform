using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void nudHour_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown numeric = sender as NumericUpDown;
			if (numeric.Value >= 24)
			{
				numeric.Value = 0;
			}
			if (numeric.Value < 0)
			{
				numeric.Value = 23;
			}
		}

		private void btnMessage_Click(object sender, EventArgs e)
		{
			ShowMessage(nudHour.Value.ToString());
		}

		void ShowMessage(string s)
		{
			MessageBox.Show(s);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Binding binding = new Binding("Value", toolStripTextBox1, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
			nudHour.DataBindings.Add(binding);
		}

		private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnMessage_Click(this, new EventArgs());
			}
		}
	}
}
