using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	class ClassB : MyClass, ICloneable
	{
		private string address;

		public string Address { get => address; set => address = value; }

		/// <summary>
		/// Tạo ra 1 thực thể mới từ chính thực thể hiện có sẵn
		/// </summary>
		/// <returns></returns>
		public new object Clone()
		{
			ClassB newClass = base.Clone() as ClassB;
			newClass.Address = this.address;

			return newClass;
		}

		public override string ToString()
		{
			return base.ToString() + " | Address: " + Address;
		}
	}
}
