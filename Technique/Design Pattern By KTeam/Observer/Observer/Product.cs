using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Product : AObserver
	{
		private string name;
		public string Name { get => name; set => name = value; }

		private List<Customer> customersList = new List<Customer>();

		public void AddCustomer(Customer customer)
		{
			if (customer != null)
			{
				customersList.Add(customer);
			}	
		}

		public void RemoveCustomer(Customer customer)
		{
			if (customer != null)
			{
				customersList.Remove(customer);
			}	
		}

		public override void ObserverInfo(string info)
		{
			foreach (Customer item in customersList)
			{
				if (item != null)
				{
					item.ObserverInfo(Name);
				}
			}
		}

		public Product(string name)
		{
			Name = name;	
		}
	}
}
