using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGUI
{
	public partial class Form1 : Form
	{
		//pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\15yearsdefqon.png");

		public Form1()
		{
			InitializeComponent();
			LoadImage();
		}

		void LoadImage()
		{
			List<string> listImage = new List<string>()
			{
				"15yearsdefqon.png",
				"TheEndshow.PNG",
				"Tin_0461 (490).jpg",
			};
			comboBoxImage.DataSource = listImage;
		}

		private void comboBoxImage_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;

			if (comboBox.SelectedValue != null)
			{
				Bitmap bitmap = new Bitmap(Application.StartupPath +
					"\\Resources\\" + comboBox.SelectedValue.ToString());
				pictureBoxImage.Image = bitmap;
			}
		}
	}
}
