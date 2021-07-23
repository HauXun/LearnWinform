using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetDemo
{
	class DataProvider
	{
		private static DataProvider instance;

		public static DataProvider Instance
		{
			get
			{ 
				if (instance == null)
				{
					instance = new DataProvider();
				}
				return instance;
			}
		}

		private DataProvider()
		{

		}

		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ADOTest;Integrated Security=True";

		public DataTable ExcuteQuery(string query, object[] parameter = null)
		{

			// DataTable -> chứa 1 bảng
			// DataSet -> chứa nhiều bảng như 1 database hoàn chỉnh
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// SqlCommand -> INSERT, UPDATE, DELETE
				// SqlDataAdapter -> SELECT
				SqlCommand command = new SqlCommand(query, connection);  // Như ThreadStart -> Thread

				if (parameter != null)
				{
					string[] temp = query.Split(' ');
					List<string> listParameter = new List<string>();
					foreach (string item in temp)
					{
						if (item[0] == '@')
						{
							listParameter.Add(item);
						}
					}
					for (int i = 0; i < parameter.Length; i++)
					{
						command.Parameters.AddWithValue(listParameter[i], parameter[i]);
					}
				}

				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(data);

				connection.Close();
			}
			return data;
		}

		public int ExcuteNonQuery(string query, object[] parameter = null)
		{
			int acceptedRows = 0;

			// DataTable -> chứa 1 bảng
			// DataSet -> chứa nhiều bảng như 1 database hoàn chỉnh
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// SqlCommand -> INSERT, UPDATE, DELETE
				// SqlDataAdapter -> SELECT
				SqlCommand command = new SqlCommand(query, connection);  // Như ThreadStart -> Thread

				if (parameter != null)
				{
					string[] temp = query.Split(' ');
					List<string> listParameter = new List<string>();
					foreach (string item in temp)
					{
						if (item[0] == '@')
						{
							listParameter.Add(item);
						}
					}
					for (int i = 0; i < parameter.Length; i++)
					{
						command.Parameters.AddWithValue(listParameter[i], parameter[i]);
					}
				}

				// Thực hiện câu query -> Trả về số dòng mà câu truy vấn thực hiện được
				acceptedRows = command.ExecuteNonQuery();

				connection.Close();
			}
			return acceptedRows;
		}

		public object ExcuteScalar(string query, object[] parameter = null)
		{
			object acceptedRows = 0;

			// DataTable -> chứa 1 bảng
			// DataSet -> chứa nhiều bảng như 1 database hoàn chỉnh
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// SqlCommand -> INSERT, UPDATE, DELETE
				// SqlDataAdapter -> SELECT
				SqlCommand command = new SqlCommand(query, connection);  // Như ThreadStart -> Thread

				if (parameter != null)
				{
					string[] temp = query.Split(' ');
					List<string> listParameter = new List<string>();
					foreach (string item in temp)
					{
						if (item[0] == '@')
						{
							listParameter.Add(item);
						}
					}
					for (int i = 0; i < parameter.Length; i++)
					{
						command.Parameters.AddWithValue(listParameter[i], parameter[i]);
					}
				}

				// Thực hiện câu query -> Trả về số dòng mà câu truy vấn thực hiện được
				acceptedRows = command.ExecuteScalar();

				connection.Close();
			}
			return acceptedRows;
		}
	}
}
