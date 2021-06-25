using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			loadLable();
		}

		void loadLable()
		{
			Label label = new Label();
			label.Text = "Có súng đây nè";
			this.Controls.Add(label);
			label.BackColor = Color.Aqua;
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			label1.Text = "Không có ai thì tui chịu thua nha";
		}

		private void label1_Click(object sender, EventArgs e)
		{
			label1.Text = "Ủa sao hok có ai hết zậy";
			Form2 f = new Form2();
			f.Show();
			f.HaiZu.Text = "Tao bắn mày nhan mày";
		}
	}
}
