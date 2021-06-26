using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Adapter
	{
		Core core = new Core();
		
		public List<string> ChuanHoaDanhSachChuoi(List<String> danhSach)
		{
			List<string> result = new List<string>();
			foreach (string item in danhSach)
			{
				result.Add(core.ChuanHoaChuoi(item));
			}
			return result;
		}
	}
}
