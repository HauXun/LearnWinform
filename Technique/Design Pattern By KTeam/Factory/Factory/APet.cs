using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	abstract class APet
	{
		public abstract void SetName(string name);
		public abstract string Talk();
	}
}
