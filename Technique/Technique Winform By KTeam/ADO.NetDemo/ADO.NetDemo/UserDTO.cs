using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetDemo
{
	class UserDTO
	{
		private string id;
		private string name;
		private DateTime dob;
		private string info;
		private bool sex;

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public DateTime Dob { get => dob; set => dob = value; }
		public string Info { get => info; set => info = value; }
		public bool Sex { get => sex; set => sex = value; }
	}
}
