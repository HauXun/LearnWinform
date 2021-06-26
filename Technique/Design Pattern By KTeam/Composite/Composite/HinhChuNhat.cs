using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class HinhChuNhat : ACore
	{
		private float dai;
		private float rong;

		public float Dai { get => dai; set => dai = value; }
		public float Rong { get => rong; set => rong = value; }

		public override float TheTich()
		{
			return Dai * Rong;
		}

		public HinhChuNhat(float dai, float rong)
		{
			Dai = dai;
			Rong = rong;
		}
	}
}
