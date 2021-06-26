using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
	class Customer : AObserver
	{
		private string name;
		private string phoneNumber;

		public string Name { get => name; set => name = value; }
		public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

		public override void ObserverInfo(string info)
		{
			MessageBox.Show($"Thông báo tới khách hàng: {Name} " +
				$"\nCó số điện thoại: {PhoneNumber} " +
				$"\nThông tin sản phẩm: {info}");
		}

		public Customer(string name, string phoneNumber)
		{
			Name = name;
			PhoneNumber = phoneNumber;
		}
	}
}
