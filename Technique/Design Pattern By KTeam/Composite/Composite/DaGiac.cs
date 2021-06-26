using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class DaGiac : ACore
	{
		List<ACore> list = new List<ACore>();

		public override float TheTich()
		{
			return list.Sum(x => x.TheTich());
		}

		public void AddShape(ACore hinh)
		{
			if (hinh != null)
			{
				list.Add(hinh);
			}	
		}

		public void RemoveShap(ACore hinh)
		{
			try
			{
				list.Remove(hinh);
			}
			catch { }
		}
	}
}
