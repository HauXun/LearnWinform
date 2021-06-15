using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQGUI
{
	class Food
	{
		private string name;
		private string price;

		public string Name { get => name; set => name = value; }
		public string Price { get => price; set => price = value; }

		public Food()
		{

		}

		public Food(string name, string price)
		{
			Name = name;
			Price = price;
		}
	}
}
