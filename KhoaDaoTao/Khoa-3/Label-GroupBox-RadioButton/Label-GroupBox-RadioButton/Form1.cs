﻿using System;
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
		public Form1()
		{
			InitializeComponent();
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
		private void Form1_CheckedChanged(object sender, EventArgs e)
		{
			var buttonsChecked = groupBox1.Controls.OfType<RadioButton>()
			   .FirstOrDefault(a => a.Checked).Text;

			labelResult.Text = buttonsChecked + ": ";
			switch (buttonsChecked)
			{
				case "Chữ nghiêng":
					label2.Font = new Font(label2.Font.Name, label2.Font.Size, FontStyle.Italic);
					return;
				case "Chữ Đậm":
					label2.Font = new Font(label2.Font.Name, label2.Font.Size, FontStyle.Bold);
					return;
				case "Chữ In Hoa":
					label2.Text = label2.Text.ToUpper();
					return;
				case "Xuống dòng":
					label2.Text += "\n - ";
					return;
			}
		}
	}
}
