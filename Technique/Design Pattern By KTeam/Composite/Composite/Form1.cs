using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		DaGiac daGiac = new DaGiac();

		private void cbHinhTron_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;

			if (checkBox.Name == cbHCN.Name)
			{
				if (checkBox.Checked)
				{
					daGiac.AddShape(new HinhChuNhat(
						(float)nudDai.Value, (float)nudRong.Value));
				}
				else
				{
					daGiac.RemoveShap(new HinhChuNhat(
						(float)nudDai.Value, (float)nudRong.Value));
				}
			}
			else if (checkBox.Name == cbHinhTron.Name)
			{
				if (checkBox.Checked)
				{
					daGiac.AddShape(new HinhTron((float)nudBanKinh.Value));
				}
				else
				{
					daGiac.RemoveShap(new HinhTron((float)nudBanKinh.Value));
				}
			}
		}

		private void buttona1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(daGiac.TheTich().ToString());
		}
	}
}
