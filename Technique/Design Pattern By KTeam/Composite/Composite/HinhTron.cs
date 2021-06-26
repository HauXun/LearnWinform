using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class HinhTron : ACore
	{
		private float banKinh;
		public float BanKinh { get => banKinh; set => banKinh = value; }

		public override float TheTich()
		{
			return (float)(BanKinh * Math.PI);
		}

		public HinhTron(float banKinh)
		{
			BanKinh = banKinh;	
		}
	}
}
