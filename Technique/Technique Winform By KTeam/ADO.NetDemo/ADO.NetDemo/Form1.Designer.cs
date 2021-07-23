
namespace ADO.NetDemo
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.btnXem = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.tbxTimKiem = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvData
			// 
			this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Location = new System.Drawing.Point(10, 10);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowTemplate.Height = 25;
			this.dgvData.Size = new System.Drawing.Size(665, 419);
			this.dgvData.TabIndex = 0;
			// 
			// btnXem
			// 
			this.btnXem.AutoSize = true;
			this.btnXem.Location = new System.Drawing.Point(12, 435);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(64, 23);
			this.btnXem.TabIndex = 1;
			this.btnXem.Text = "Xem";
			this.btnXem.UseVisualStyleBackColor = true;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// btnThem
			// 
			this.btnThem.AutoSize = true;
			this.btnThem.Location = new System.Drawing.Point(82, 435);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(64, 23);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.AutoSize = true;
			this.btnXoa.Location = new System.Drawing.Point(151, 435);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(64, 23);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.AutoSize = true;
			this.btnSua.Location = new System.Drawing.Point(221, 435);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(64, 23);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.AutoSize = true;
			this.btnTimKiem.Location = new System.Drawing.Point(456, 435);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(64, 23);
			this.btnTimKiem.TabIndex = 5;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// tbxTimKiem
			// 
			this.tbxTimKiem.Location = new System.Drawing.Point(320, 437);
			this.tbxTimKiem.Name = "tbxTimKiem";
			this.tbxTimKiem.Size = new System.Drawing.Size(130, 20);
			this.tbxTimKiem.TabIndex = 6;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(320, 464);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(686, 494);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.tbxTimKiem);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnXem);
			this.Controls.Add(this.dgvData);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox tbxTimKiem;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}

