using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetDemo
{
	class UserBUSINESS
	{
		private static UserBUSINESS instance;

		public static UserBUSINESS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new UserBUSINESS();
				}
				return instance;
			}
		}

		private UserBUSINESS()
		{

		}

		public void View(DataGridView data)
		{
			data.DataSource = UserDAO.Instance.View();
		}

		public void SearchBy_NgaySinh(DataGridView data, DateTimePicker dtpk)
		{
			data.DataSource = UserDAO.Instance.SearchBy_NgaySinh(dtpk);
		}

		public bool DeleteBy_ID(DataGridView data)
		{
			string ID = data.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
			return UserDAO.Instance.DeleteBy_ID(ID);
		}

		public bool EditBy_ID(DataGridView data)
		{
			DataGridViewRow row = data.SelectedCells[0].OwningRow;
			string oldId = row.Cells["ID"].Value.ToString();

			string id = row.Cells["ID"].Value.ToString();
			string name = row.Cells["NAME"].Value.ToString();
			DateTime dob = (DateTime)row.Cells["DOB"].Value;
			string info = row.Cells["INFO"].Value.ToString();
			bool sex = false;
			try
			{
				sex = (bool)row.Cells["SEX"].Value;
			}
			catch { }

			UserDTO user = new UserDTO()
			{
				Id = id,
				Name = name,
				Dob = dob,
				Info = info,
				Sex = sex
			};

			return UserDAO.Instance.EditBy_ID(id, user);
		}

		public bool Add(DataGridView data)
		{
			DataGridViewRow row = data.SelectedCells[0].OwningRow;

			string id = row.Cells["ID"].Value.ToString();
			string name = row.Cells["NAME"].Value.ToString();
			DateTime dob = new DateTime(1900, 1, 1);
			try
			{
				dob = (DateTime)row.Cells["DOB"].Value;
			}
			catch { } 
			string info = row.Cells["INFO"].Value.ToString();
			bool sex =  false;
			try
			{
				sex = (bool)row.Cells["SEX"].Value;
			}
			catch { }

			UserDTO user = new UserDTO()
			{
				Id = id,
				Name = name,
				Dob = dob,
				Info = info,
				Sex = sex
			};

			return UserDAO.Instance.Add( user);
		}
	}
}
