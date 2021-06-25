using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_GroupBox_CheckBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string text = "";
			foreach (Control control in groupBoxSelect.Controls)
			{
				if (control is CheckBox)
					if ((control as CheckBox).Checked)
						text += "\r\n- " + control.Text;
			}

			// Kiểm tra kết quả
			if (text == "")
			{
				labelResult.Text = "Bạn chưa lựa chọn thuộc tính nào ở trên!";
			}
			else
			{
				labelResult.Text = "Các thuộc tính đã lựa chọn:\r\n" + text;
			}
		}
	}
}
