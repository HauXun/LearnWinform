using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void GetProcess()
		{
			Process p1 = Process.GetCurrentProcess();
			textBox1.Text = p1.ProcessName + "\n" + textBox1.Text;

			Process[] processes = Process.GetProcesses();
			foreach (Process item in processes)
			{
				textBox1.Text = item.ProcessName + "\n" + textBox1.Text;
			}
		}

		private void buttonProcess_Click(object sender, EventArgs e)
		{
			GetProcess();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			Process.Start("notepad");
			//Process.Start(Application.StartupPath + "\\ProcessGUI.exe");
			//Process.Start(@"https:\\www.youtube.com/watch?v=epec4etkaW4&list=PL33lvabfss1y2T7yK--YZJHCsU7LZVzBS&index=23");
		}

		private void buttonHidden_Click(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.FileName = Application.StartupPath + "\\ProcessGUI.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
			process.Start();
		}
	}
}
