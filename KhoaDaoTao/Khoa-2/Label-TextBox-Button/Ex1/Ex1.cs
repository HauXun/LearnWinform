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
	public partial class Ex1 : Form
	{
		public Ex1()
		{
			InitializeComponent();
		}

		private void buttonGreen_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Green;
			this.Text = "Green Background Color!";
		}

		private void buttonYellow_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Yellow;
			this.Text = "Yellow Background Color!";
		}
	}
}
