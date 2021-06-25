using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.BackColor = Color.Black;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			Button button = sender as Button;
			button.BackColor = Color.FromArgb(250, 255, 255);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}	
		}
	}
}
