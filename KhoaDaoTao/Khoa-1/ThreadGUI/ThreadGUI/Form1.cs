using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ThreadStart threadStart = new ThreadStart(Demo);
			Thread thread = new Thread(threadStart);
			thread.IsBackground = true;
			thread.Start();
		}

		void Demo()
		{
			for (int i = 0; i < int.Parse(textBox1.Text); i++)
			{
				label1.Text = i.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Có súng đây nè!");
		}

		int speed = 100;
		void MovePictureBox()
		{
			new Thread(
			() =>
			{
				while (true)
				{
					if (Left.Checked)
					{
						pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
					}
					else
					{
						pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
					}
					Thread.Sleep(speed);
				}
			}
			)
			{ IsBackground = true }.Start();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MovePictureBox();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(textBox2.Text, out speed))
			{

			}
		}
	}
}
