using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
	class SingletonClass
	{
		private static volatile object key = new object();	// volatile: Tránh đụng độ Thread
		private static SingletonClass instance;
		public static SingletonClass Instance
		{
			get
			{
				if (instance == null)
				{
					lock (key)
					{
						instance = new SingletonClass();
					}
				}
				return instance;
			}
			set => instance = value;
		}

		private SingletonClass()
		{

		}

		public void Demo() => MessageBox.Show("Có súng đây nè!");

		public void PrintString(string s) => MessageBox.Show(s);
	}
}
