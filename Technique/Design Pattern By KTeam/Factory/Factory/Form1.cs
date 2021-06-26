using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			APeople aPeople1 = new PeopleWithDog();
			aPeople1.SetPet();
			APeople aPeople2 = new PeopleWithCat();
			aPeople2.SetPet();

			aPeople1.PetInfo();
			aPeople2.PetInfo();
		}
	}
}
