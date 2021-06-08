using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button button = new Button();
			button.Text = "Việt Nam Cộng Sản Muôn Năm :v";
			button.AutoSize = true;

			Random random = new Random();
			button.Location = new Point(random.Next(0, panelButton.Size.Width), random.Next(0, panelButton.Size.Height));

			//panelButton.Controls.Add(button);
			flowLayoutPanelButton.Controls.Add(button);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			panelButton.Enabled = !panelButton.Enabled;
		}
	}
}
