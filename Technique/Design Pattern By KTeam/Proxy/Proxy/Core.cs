using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class Core : ACore
	{
		private string name;
		public string Name { get => name; set => name = value; }

		public override string GetName() => this.name;

		public Core(string name)
		{
			Name = name;
		}
	}
}
