using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripGUI
{
	public partial class Input : Form
	{
		public Input()
		{
			InitializeComponent();
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			Constain.Name = textBox1.Text;
			this.Close();
		}

		public event EventHandler OkeBro;
	}
}
