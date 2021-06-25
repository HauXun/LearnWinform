using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding
{
	class MyAge : INotifyPropertyChanged
	{
		private DateTime date;
		public DateTime Date 
		{
			get => date;
			set
			{
				date = value;
				age = (DateTime.Now.Year - Date.Year).ToString();
				OnPropertyChanged("Date");
			}
		}

		private string age;
		public string Age 
		{ 
			get => age;
			set
			{
				age = value;
				OnPropertyChanged("Age");
			}
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
