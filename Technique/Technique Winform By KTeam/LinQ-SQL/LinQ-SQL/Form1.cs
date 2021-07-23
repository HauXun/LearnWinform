using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_SQL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// dataGridView1.AutoSize = true;
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			using (DataClassesSQLDataContext data = new DataClassesSQLDataContext())
			{
				dataGridView1.DataSource = data.UserAccounts.Select(x => x);

				// dataGridView1.DataSource = data.UserAccounts.Where(x => x.Username.CompareTo("Admin") == 0);

				// dataGridView1.DataSource = from item in data.UserAccounts
				//						   where item.RoleID.CompareTo("User") == 0
				//						   // orderby item.UserID ascending
				//						   select item;

				// dataGridView1.DataSource = from item in data.UserAccounts
				//						   join item2 in data.UserRoles
				//						   on item.RoleID equals item2.RoleID
				//						   into newTable
				//						   orderby item.UserID descending
				//						   select newTable.FirstOrDefault();

				// dataGridView1.DataSource = from item in data.UserAccounts
				//						   from item2 in data.UserRoles
				//						   where item.RoleID == item2.RoleID
				//						   orderby item2.RoleID descending
				//						   select new {
				//							   ID = item.RoleID,
				//							   Tên = item.FullName,
				//							   Mật_Khẩu = item.Password
				//						   } into newSelect 
				//						   where newSelect.ID.CompareTo("User") == 0 
				//						   select newSelect;
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			using (DataClassesSQLDataContext data = new DataClassesSQLDataContext())
			{
				///

				int userID = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString());

				// ...

				DateTime? createAt =
					dataGridView1.SelectedCells[0].OwningRow.Cells["CreateAt"].Value == null
					? null :
					(DateTime?)dataGridView1.SelectedCells[0].OwningRow.Cells["CreateAt"].Value;

				UserAccount insertAccount = new UserAccount();

				insertAccount.UserID = userID;
				/* account.RoleID = ... ;
				...
				account.CreateAt = createAt;
				*/

				data.UserAccounts.InsertOnSubmit(insertAccount);

				data.SubmitChanges();

				///
				// Add in new Form
			}
			btnXem_Click(sender, e);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			using (DataClassesSQLDataContext data = new DataClassesSQLDataContext())
			{
				int userID = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString());

				UserAccount accountDeletes = data.UserAccounts.Where(x =>
				x.UserID.Equals(userID)).SingleOrDefault();

				data.UserAccounts.DeleteOnSubmit(accountDeletes);
				data.SubmitChanges();
			}
			btnXem_Click(sender, e);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			using (DataClassesSQLDataContext data = new DataClassesSQLDataContext())
			{
				// ...

				string userID = dataGridView1.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString();

				// ...

				DateTime? createAt =
					dataGridView1.SelectedCells[0].OwningRow.Cells["CreateAt"].Value == null
					? null :
					(DateTime?)dataGridView1.SelectedCells[0].OwningRow.Cells["CreateAt"].Value;

				UserAccount account = data.UserAccounts.Where(x =>
				x.UserID.Equals(userID)).SingleOrDefault();

				// ...

				/*
				...
				account.RoleID = ... ;
				...
				account.CreateAt = createAt;
				...
				*/

				data.SubmitChanges();
			}
			btnXem_Click(sender, e);
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			using (DataClassesSQLDataContext data = new DataClassesSQLDataContext())
			{
				dataGridView1.DataSource = data.UserAccounts.Where(x =>
				x.UserID.Equals(tbxTimKiem.Text));
			}
		}
	}
}
