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

namespace ADO.NetDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			UserBUSINESS.Instance.View(dgvData);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (UserBUSINESS.Instance.Add(dgvData))
			{
				MessageBox.Show("Thêm thành công");
				btnXem_Click(sender, e);
			}
			else
			{
				MessageBox.Show("Thêm không thành công");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (UserBUSINESS.Instance.DeleteBy_ID(dgvData))
			{
				MessageBox.Show("Xóa thành công");
				btnXem_Click(sender, e);
			}
			else
			{
				MessageBox.Show("Xóa không thành công");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (UserBUSINESS.Instance.EditBy_ID(dgvData))
			{
				MessageBox.Show("Sửa thành công");
				btnXem_Click(sender, e);
			}
			else
			{
				MessageBox.Show("Sửa không thành công");
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			UserBUSINESS.Instance.SearchBy_NgaySinh(dgvData, dateTimePicker1);
		}
	}
}
