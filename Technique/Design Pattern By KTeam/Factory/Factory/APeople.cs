using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
	abstract class APeople
	{
		protected APet myPet;
		public abstract void SetPet();
		public void PetInfo()
		{
			MessageBox.Show("My pet said: " + myPet.Talk());
		}
	}
}
