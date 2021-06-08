using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void ShowResultRadio(Label label, Panel panel)
		{
			RadioButton radioButton = null;

			foreach (RadioButton item in panel.Controls)
			{
				if (item != null)
					if (item.Checked)
					{
						radioButton = item;
						break;
					}
			}

			if (radioButton != null)
			{
				label.Text = radioButton.Text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowResultRadio(label1, panel1);
			ShowResultRadio(label2, panel2);
			ShowResultRadio(label3, panel3);
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radio = sender as RadioButton;

			if (radio.Checked)
			{
				label1.Text = radio.Text;
			}
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radio = sender as RadioButton;

			if (radio.Checked)
			{
				label2.Text = radio.Text;
			}
		}

		private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
		{
			RadioButton radio = sender as RadioButton;

			if (radio.Checked)
			{
				label3.Text = radio.Text;
			}
		}
	}
}
