using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_GroupBox_RadioButton
{
	public partial class Form1 : Form
	{
		FontDialog fontDlg = new FontDialog();
		public Form1()
		{
			InitializeComponent();

		}

		void DefaultFont()
		{
			fontDlg.Font = new Font("Segoe UI", 9, FontStyle.Strikeout);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Control c in groupBox1.Controls)
			{
				if (c is RadioButton)
				{
					(c as RadioButton).CheckedChanged += Form1_CheckedChanged;
				}
			}
		}

		Label tempLabel;
		private void Form1_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;

			if (radioButton.Checked)
			{
				if (tempLabel == null)
				{
					tempLabel = new Label();
					tempLabel.Text = label2.Text;
					tempLabel.Font = new Font(tempLabel.Font, FontStyle.Regular);
				}
				label2.Text = tempLabel.Text;
				label2.Font = tempLabel.Font;

				var buttonsChecked = groupBox1.Controls.OfType<RadioButton>()
				   .FirstOrDefault(a => a.Checked).Text;

				labelResult.Text = buttonsChecked + ": ";
				switch (buttonsChecked)
				{
					case "Chữ nghiêng":
						label2.Font = new Font(label2.Font.Name, label2.Font.Size, FontStyle.Italic);
						break;
					case "Chữ Đậm":
						label2.Font = new Font(label2.Font.Name, label2.Font.Size, FontStyle.Bold);
						break;
					case "Chữ In Hoa":
						label2.Text = label2.Text.ToUpper();
						break;
					case "Xuống dòng":
						label2.Text = tempLabel.Text;
						label2.Text += "\n - ";
						break;
				}
				radioButton.Checked = !radioButton.Checked;
			}
		}
	}
}
