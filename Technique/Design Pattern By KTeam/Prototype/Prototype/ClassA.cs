using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	class ClassA : MyClass, ICloneable
	{
		private string info;

		public string Info { get => info; set => info = value; }

		/// <summary>
		/// Tạo ra 1 thực thể mới từ chính thực thể hiện có sẵn
		/// </summary>
		/// <returns></returns>
		public new object Clone()
		{
			ClassA newClass = base.Clone() as ClassA;
			newClass.Info = this.info;

			return newClass;
		}

		public override string ToString()
		{
			return base.ToString() + " | Info: " + Info;
		}
	}
}
