using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	class MyClass : ICloneable
	{
		private string id;
		private string name;

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }

		/// <summary>
		/// Tạo ra 1 thực thể mới từ chính thực thể hiện có sẵn
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return new MyClass() { Name = this.name, Id = this.id };
		}

		public override string ToString()
		{
			return "ID: " + Id + " | " + "Name: " + Name;
		}
	}
}
