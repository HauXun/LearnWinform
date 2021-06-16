using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
	public partial class Ex2 : Form
	{
		public Ex2()
		{
			InitializeComponent();
		}

		private void buttonDisplay_Click(object sender, EventArgs e)
		{
			textBoxDisplay.Text = "Có súng đây nè!";
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//textBoxDisplay.Text = "";
			textBoxDisplay.Clear();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			//this.Close();

			DialogResult result = MessageBox.Show("Thoát chương trình!", "Close!",
				MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
