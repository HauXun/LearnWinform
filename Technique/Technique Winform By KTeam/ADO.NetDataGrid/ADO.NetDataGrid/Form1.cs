using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetDataGrid
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			dataGridView1.AutoSize = true;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.DataSource = GetAllTaiKhoan().Tables[0];
		}

		DataSet GetAllTaiKhoan()
		{
			DataSet data = new DataSet();
			int ID = 2;
			string name = "Admin";
			string query = "SELECT * FROM UserAccount";
			using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand();
				//command.Parameters.AddWithValue("@Username", name);
				//ID = (int)command.ExecuteScalar();

				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				adapter.Fill(data);

				connection.Close();
			}
			return data;
		}
	}
}
