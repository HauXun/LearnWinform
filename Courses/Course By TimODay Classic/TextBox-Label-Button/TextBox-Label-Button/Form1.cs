using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_Label_Button
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBoxDisplay_TextChanged(object sender, EventArgs e)
		{
			if (textBoxDisplay.Text.Trim() != "")
			{
				buttonView.Enabled = true;
			}
			else
			{
				buttonView.Enabled = false;
			}
		}

		private void buttonView_Click(object sender, EventArgs e)
		{
			labelDisplay.Text = textBoxDisplay.Text;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
