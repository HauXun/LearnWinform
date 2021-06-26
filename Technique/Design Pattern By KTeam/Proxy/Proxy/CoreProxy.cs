using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class CoreProxy : ACore
	{
		private bool isAdmin = false;
		public override string GetName()
		{
			if (isAdmin)
			{
				Core core = new Core("Chần Dần");
				return core.GetName();
			}
			return null;
		}

		public CoreProxy(bool isAdmin)
		{
			this.isAdmin = isAdmin;
		}
	}
}
