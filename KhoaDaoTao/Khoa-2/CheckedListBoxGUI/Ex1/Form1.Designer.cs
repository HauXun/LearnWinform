
namespace Ex1
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
			this.label1 = new System.Windows.Forms.Label();
			this.checkedListBoxDanhSach = new System.Windows.Forms.CheckedListBox();
			this.listViewDanhSachChon = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.buttonXem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách các mặt hàng:";
			// 
			// checkedListBoxDanhSach
			// 
			this.checkedListBoxDanhSach.CheckOnClick = true;
			this.checkedListBoxDanhSach.FormattingEnabled = true;
			this.checkedListBoxDanhSach.Items.AddRange(new object[] {
            "Làm thịt Malaysia",
            "Bóp cổ chết mẹ thằng Indo",
            "Tra tấn thằng UAE",
            "Anh cả ĐNÁ",
            "Vị vua mới của ĐNÁ"});
			this.checkedListBoxDanhSach.Location = new System.Drawing.Point(13, 35);
			this.checkedListBoxDanhSach.Name = "checkedListBoxDanhSach";
			this.checkedListBoxDanhSach.Size = new System.Drawing.Size(195, 144);
			this.checkedListBoxDanhSach.TabIndex = 1;
			// 
			// listViewDanhSachChon
			// 
			this.listViewDanhSachChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listViewDanhSachChon.FullRowSelect = true;
			this.listViewDanhSachChon.GridLines = true;
			this.listViewDanhSachChon.HideSelection = false;
			this.listViewDanhSachChon.Location = new System.Drawing.Point(229, 35);
			this.listViewDanhSachChon.Name = "listViewDanhSachChon";
			this.listViewDanhSachChon.Size = new System.Drawing.Size(240, 244);
			this.listViewDanhSachChon.TabIndex = 2;
			this.listViewDanhSachChon.UseCompatibleStateImageBehavior = false;
			this.listViewDanhSachChon.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Các sản phẩm đã chọn";
			this.columnHeader2.Width = 200;
			// 
			// buttonXem
			// 
			this.buttonXem.AutoSize = true;
			this.buttonXem.Location = new System.Drawing.Point(56, 206);
			this.buttonXem.Name = "buttonXem";
			this.buttonXem.Size = new System.Drawing.Size(119, 29);
			this.buttonXem.TabIndex = 3;
			this.buttonXem.Text = "Xem";
			this.buttonXem.UseVisualStyleBackColor = true;
			this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.buttonXem);
			this.Controls.Add(this.listViewDanhSachChon);
			this.Controls.Add(this.checkedListBoxDanhSach);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox checkedListBoxDanhSach;
		private System.Windows.Forms.ListView listViewDanhSachChon;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button buttonXem;
	}
}

