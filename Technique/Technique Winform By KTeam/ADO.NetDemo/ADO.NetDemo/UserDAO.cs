using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetDemo
{
	class UserDAO
	{
		private static UserDAO instance;

		public static UserDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new UserDAO();
				}
				return instance;
			}
		}

		private UserDAO()
		{

		}

		public DataTable View()
		{
			string query = "SELECT * FROM dbo.THONGTIN";
			return DataProvider.Instance.ExcuteQuery(query);
		}

		public DataTable SearchBy_NgaySinh(DateTimePicker dtpk)
		{
			object[] parameter = new object[] { dtpk.Value };
			string query = "SELECT * FROM dbo.THONGTIN WHERE DOB > @DOB";
			return DataProvider.Instance.ExcuteQuery(query, parameter);
		}

		public bool DeleteBy_ID(string id)
		{
			string query = "DELETE THONGTIN WHERE ID = @ID";
			object[] parameter = new object[] { id };
			if (DataProvider.Instance.ExcuteNonQuery(query, parameter) > 0)
				return true;
			return false;
		}

		public bool EditBy_ID(string id, UserDTO user)
		{
			string query = "UPDATE THONGTIN SET NAME = @Name , DOB = @DOB , INFO = @Info , SEX = @Sex WHERE ID = @OldID";
			object[] parameter = new object[] { user.Name, user.Dob, user.Info, user.Sex, id };
			if (DataProvider.Instance.ExcuteNonQuery(query, parameter) > 0)
				return true;
			return false;
		}

		public bool Add(UserDTO user)
		{
			string query = "INSERT INTO THONGTIN VALUES ( @Id , @Name , @DOB , @Info , @Sex )";
			if (IDCheckExist(user.Id))
			{
				user.Id = (MaxID() + 1).ToString();
			}	
			object[] parameter = new object[] { user.Id, user.Name, user.Dob, user.Info, user.Sex};
			if (DataProvider.Instance.ExcuteNonQuery(query, parameter) > 0)
				return true;
			return false;
		}

		public int MaxID()
		{
			string query = "SELECT MAX(ID) FROM THONGTIN";
			return int.Parse((string)DataProvider.Instance.ExcuteScalar(query));
		}

		bool IDCheckExist(string id)
		{
			string query = "SELECT ID FROM THONGTIN WHERE ID = @ID";
			object[] parameter = new object[] { id };
			if (DataProvider.Instance.ExcuteQuery(query, parameter).Rows.Count > 0)
				return true;
			return false;
		}
	}
}
