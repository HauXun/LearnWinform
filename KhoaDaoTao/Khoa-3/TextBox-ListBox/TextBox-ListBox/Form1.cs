using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ListBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			listBoxThietBi.Items.Add("MOUSE");
		}

		private void listBoxThietBi_SelectedIndexChanged(object sender, EventArgs e)
		{
			//textBoxResult.Text = listBoxThietBi.SelectedItem.ToString();
		}

		private void listBoxThietBi_Click(object sender, EventArgs e)
		{
			textBoxResult.Text = listBoxThietBi.SelectedItem.ToString();
		}
	}
}
