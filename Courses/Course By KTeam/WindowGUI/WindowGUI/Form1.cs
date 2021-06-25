using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int i = 0;
		private void FormClick(object sender, EventArgs e)
		{
			MessageBox.Show($"Bạn đã click lên Form {i++} lần");
		}
	}
}
