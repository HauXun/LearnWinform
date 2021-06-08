using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int number = 0;
			if (int.TryParse(textBoxValue.Text, out number))
				labelValue.Text = Math.Pow(number, 2).ToString();
			else
				labelValue.Text = "Nhập số đi thằng Hai Zụ";
		}

		private void textBoxValue_TextChanged(object sender, EventArgs e)
		{
			int number = 0;
			if (int.TryParse(textBoxValue.Text, out number))
				labelValue.Text = Math.Pow(number, 2).ToString();
			else
				labelValue.Text = "Nhập số đi thằng Hai Zụ";
		}
	}
}
