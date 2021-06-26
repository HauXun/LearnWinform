using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product product = new Product("Dell U3421D UltraWide 21:9 IPS 2K 100% SRgb");

			Customer customer1 = new Customer("Chần Giần", "19001121");
			Customer customer2 = new Customer("Hai Zụ", "00000401");

			product.AddCustomer(customer1);
			product.AddCustomer(customer2);

			product.ObserverInfo("");
		}
	}
}
