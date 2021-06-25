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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool onOff = true;

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBoxOff.Visible = false;
			pictureBoxOn.Visible = true;

			buttonOnOff.Text = "EndShow!";
		}

		private void buttonOnOff_Click(object sender, EventArgs e)
		{
			if (onOff)
			{
				pictureBoxOff.Visible = true;
				pictureBoxOn.Visible = false;

				buttonOnOff.Text = "The Show Must Go On!";
				onOff = false;
			}
			else
			{
				pictureBoxOff.Visible = false;
				pictureBoxOn.Visible = true;

				buttonOnOff.Text = "EndShow!";
				onOff = true;
			}	
		}
	}
}
