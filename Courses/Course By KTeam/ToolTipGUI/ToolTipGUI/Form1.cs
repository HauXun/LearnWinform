using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTipGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			ToolTip toolTip = new ToolTip() {
				InitialDelay = 0,
				IsBalloon = true,
				ToolTipIcon = ToolTipIcon.Error,
				ToolTipTitle = "???"
			};
			toolTip.SetToolTip(button2, "Có súng đây nè!");
		}
	}
}
