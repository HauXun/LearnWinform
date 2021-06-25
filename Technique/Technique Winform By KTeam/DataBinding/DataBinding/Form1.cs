using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//Load();
			LoadMyAge();
		}

		MyClass myClass = new MyClass("4");
		void Load()
		{
			Binding dataBinding = new Binding("Text", myClass, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
			textBox1.DataBindings.Add(dataBinding);
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			myClass.Name = textBox2.Text;
		}

		MyAge myAge = new MyAge();
		void LoadMyAge()
		{
			Binding dataBinding = new Binding("Value", myAge, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
			dateTimePicker1.DataBindings.Add(dataBinding);

			Binding dataBinding2 = new Binding("Text", myAge, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
			textBox1.DataBindings.Add(dataBinding2);
		}
	}
}
