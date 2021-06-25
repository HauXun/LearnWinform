using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusBarGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			LoadStatusStrip();
		}

		void LoadStatusStrip()
		{
			ToolStripLabel item = new ToolStripLabel() { Text = "Láo cá chó" };
			ToolStripProgressBar item2 = new ToolStripProgressBar();
			ToolStripComboBox item3 = new ToolStripComboBox() { Text = "Tao lóc mày nhan mày" };
			statusStrip1.Items.Add(item);
			statusStrip1.Items.Add(item2);
			statusStrip1.Items.Add(item3);
		}
	}
}
