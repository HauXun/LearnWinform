using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	class PeopleWithDog : APeople
	{
		public override void SetPet()
		{
			myPet = new Dog("Đót gâu gâu");
		}
	}
}
