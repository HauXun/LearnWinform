using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBox1_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Click");
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("CheckedChanged");
		}

		private void checkBox1_CheckStateChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("CheckStateChanged");
		}

		private void buttonClick_Click(object sender, EventArgs e)
		{
			string name = textBoxName.Text;
			string isBaSoc = checkBox3Soc.CheckState == CheckState.Checked ? "là" :
				checkBox3Soc.CheckState == CheckState.Unchecked ? "không phải là" : "phải cũng không phải là";
			string showFormat = string.Format("Chào {0} nha, bạn {1} ba sọc á", name, isBaSoc);

			MessageBox.Show(showFormat);
		}
	}
}
