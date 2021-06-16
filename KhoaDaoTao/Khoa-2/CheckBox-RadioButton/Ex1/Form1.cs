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

		private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonRed.Checked)
			{
				textBoxData.ForeColor = Color.Red;
			}
		}

		private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonGreen.Checked)
			{
				textBoxData.ForeColor = Color.Green;
			}
		}

		private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonBlue.Checked)
			{
				textBoxData.ForeColor = Color.Blue;
			}
		}

		private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonBlack.Checked)
			{
				textBoxData.ForeColor = Color.Black;
			}
		}

		private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
		{
			textBoxData.Font = new Font(textBoxData.Font.Name,
				textBoxData.Font.Size, textBoxData.Font.Style ^ FontStyle.Bold);
		}

		private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
		{
			textBoxData.Font = new Font(textBoxData.Font.Name,
				textBoxData.Font.Size, textBoxData.Font.Style ^ FontStyle.Italic);
		}

		private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e)
		{
			textBoxData.Font = new Font(textBoxData.Font.Name,
				textBoxData.Font.Size, textBoxData.Font.Style ^ FontStyle.Underline);
		}
	}
}
