using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	class Cat : APet
	{
		private string name;
		public string Name { get => name; set => name = value; }

		public override void SetName(string name)
		{
			Name = name;
		}

		public override string Talk()
		{
			return Name;
		}

		public Cat(string name)
		{
			Name = name;
		}
	}
}
