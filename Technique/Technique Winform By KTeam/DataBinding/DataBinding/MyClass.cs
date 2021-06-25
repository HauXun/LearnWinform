using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
	class MyClass : INotifyPropertyChanged
	{
		private string name;
		public string Name
		{
			get => name;
			set
			{
				if (name == value.ToString())
					return;
				int a = int.Parse(value.ToString());
				name = (a * a).ToString();
				OnPropertyChanged("name");
			}
		}

		public MyClass(string name)
		{
			Name = name;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string name)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(name));
			}	
		}
	}
}
