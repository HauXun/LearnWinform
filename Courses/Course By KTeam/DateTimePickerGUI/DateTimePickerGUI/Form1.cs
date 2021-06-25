using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			dateTimePicker1.ShowUpDown = true;
			DateTime date = dateTimePicker1.Value;
			date.AddDays(5);
			date.AddDays(-5);
			//date.??
			DateTime now = DateTime.Now;
		}
	}
}
