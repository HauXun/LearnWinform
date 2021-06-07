using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int i = 0;
		void AddButton()
		{
			Random random = new Random();
			Button button = new Button(); // { Text = i++.ToString(), Location = new Point(
			//	random.Next(0, this.Size.Width), random.Next(0, this.Size.Height))};
			button.Text = i++.ToString();
			button.Location = new Point(
			random.Next(0, this.Size.Width), random.Next(0, this.Size.Height));
			button.Click += Button_Click;

			this.Controls.Add(button);
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			MessageBox.Show(button.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddButton();
		}
	}
}
