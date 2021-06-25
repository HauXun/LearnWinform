using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGUI
{
	public partial class Form1 : Form
	{
		Timer timer1;
		public Form1()
		{
			InitializeComponent();
			timer1 = new Timer();
			timer1.Tick += timer1_Tick;
			timer1.Interval = 1000;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			timer1.Enabled = !timer1.Enabled;
			buttonStart.Text = buttonStart.Text == "Start" ? "Start" : "Stop";

			//if (!timer1.Enabled)
			//{
			//	buttonStart.Text = "Stop";
			//	timer1.Start();
			//}
			//else
			//{
			//	buttonStart.Text = "Start";
			//	timer1.Stop();
			//}
		}

		int i = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			i++;
			label1.Text = i.ToString();
		}
	}
}
