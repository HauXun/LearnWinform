using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Có súng đây nè", "Súng đou ?",
				MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,
				MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification);

			switch (result)
			{
				case DialogResult.None:
					break;
				case DialogResult.OK:
					break;
				case DialogResult.Cancel:
					MessageBox.Show("Chạy đi :v");
					break;
				case DialogResult.Abort:
					break;
				case DialogResult.Retry:
					break;
				case DialogResult.Ignore:
					break;
				case DialogResult.Yes:
					MessageBox.Show("Súng trong túi :v");
					break;
				case DialogResult.No:
					MessageBox.Show("Làm gi có súng :v");
					break;
				default:
					break;
			}
		}
	}
}
