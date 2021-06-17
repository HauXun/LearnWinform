
namespace ComboBoxGUI
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
			this.components = new System.ComponentModel.Container();
			this.labelInfo = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNumberPhone = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
			this.groupBoxDonHang = new System.Windows.Forms.GroupBox();
			this.listBoxMatHang = new System.Windows.Forms.ListBox();
			this.groupBoxHinhThucTT = new System.Windows.Forms.GroupBox();
			this.comboBoxHinhThucTT = new System.Windows.Forms.ComboBox();
			this.buttonDatHang = new System.Windows.Forms.Button();
			this.buttonEnd = new System.Windows.Forms.Button();
			this.groupBoxInfo = new System.Windows.Forms.GroupBox();
			this.textBoxInfo = new System.Windows.Forms.TextBox();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.comboBoxRegionPhoneNumber = new System.Windows.Forms.ComboBox();
			this.groupBoxDonHang.SuspendLayout();
			this.groupBoxHinhThucTT.SuspendLayout();
			this.groupBoxInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Location = new System.Drawing.Point(148, 9);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(131, 19);
			this.labelInfo.TabIndex = 0;
			this.labelInfo.Text = "Thông tin đơn hàng";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 38);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(54, 19);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Họ tên:";
			// 
			// labelNumberPhone
			// 
			this.labelNumberPhone.AutoSize = true;
			this.labelNumberPhone.Location = new System.Drawing.Point(3, 73);
			this.labelNumberPhone.Name = "labelNumberPhone";
			this.labelNumberPhone.Size = new System.Drawing.Size(47, 19);
			this.labelNumberPhone.TabIndex = 2;
			this.labelNumberPhone.Text = "Số DT:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(76, 35);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(282, 25);
			this.textBoxName.TabIndex = 3;
			// 
			// textBoxNumberPhone
			// 
			this.textBoxNumberPhone.Location = new System.Drawing.Point(148, 70);
			this.textBoxNumberPhone.Name = "textBoxNumberPhone";
			this.textBoxNumberPhone.Size = new System.Drawing.Size(210, 25);
			this.textBoxNumberPhone.TabIndex = 4;
			// 
			// groupBoxDonHang
			// 
			this.groupBoxDonHang.Controls.Add(this.listBoxMatHang);
			this.groupBoxDonHang.Location = new System.Drawing.Point(12, 101);
			this.groupBoxDonHang.Name = "groupBoxDonHang";
			this.groupBoxDonHang.Size = new System.Drawing.Size(346, 233);
			this.groupBoxDonHang.TabIndex = 5;
			this.groupBoxDonHang.TabStop = false;
			this.groupBoxDonHang.Text = "Danh sách đơn hàng";
			// 
			// listBoxMatHang
			// 
			this.listBoxMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxMatHang.FormattingEnabled = true;
			this.listBoxMatHang.ItemHeight = 17;
			this.listBoxMatHang.Items.AddRange(new object[] {
            "5 ông lục tổ",
            "Ánh hào quang",
            "Cái Chum",
            "Chửi lộn đại cương",
            "Cửu pháp chân truyền"});
			this.listBoxMatHang.Location = new System.Drawing.Point(3, 21);
			this.listBoxMatHang.Name = "listBoxMatHang";
			this.listBoxMatHang.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxMatHang.Size = new System.Drawing.Size(340, 209);
			this.listBoxMatHang.TabIndex = 0;
			// 
			// groupBoxHinhThucTT
			// 
			this.groupBoxHinhThucTT.Controls.Add(this.comboBoxHinhThucTT);
			this.groupBoxHinhThucTT.Location = new System.Drawing.Point(15, 340);
			this.groupBoxHinhThucTT.Name = "groupBoxHinhThucTT";
			this.groupBoxHinhThucTT.Size = new System.Drawing.Size(340, 48);
			this.groupBoxHinhThucTT.TabIndex = 6;
			this.groupBoxHinhThucTT.TabStop = false;
			this.groupBoxHinhThucTT.Text = "Hình thức thanh toán";
			// 
			// comboBoxHinhThucTT
			// 
			this.comboBoxHinhThucTT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxHinhThucTT.FormattingEnabled = true;
			this.comboBoxHinhThucTT.Items.AddRange(new object[] {
            "Thanh toán khi nhận hàng",
            "Thanh toán qua ATM",
            "Thanh toán qua ví MoMo",
            "Thanh toán qua ví ZaloPay"});
			this.comboBoxHinhThucTT.Location = new System.Drawing.Point(3, 21);
			this.comboBoxHinhThucTT.Name = "comboBoxHinhThucTT";
			this.comboBoxHinhThucTT.Size = new System.Drawing.Size(334, 25);
			this.comboBoxHinhThucTT.TabIndex = 0;
			this.comboBoxHinhThucTT.SelectedIndexChanged += new System.EventHandler(this.comboBoxHinhThucTT_SelectedIndexChanged);
			// 
			// buttonDatHang
			// 
			this.buttonDatHang.AutoSize = true;
			this.buttonDatHang.Location = new System.Drawing.Point(37, 394);
			this.buttonDatHang.Name = "buttonDatHang";
			this.buttonDatHang.Size = new System.Drawing.Size(76, 29);
			this.buttonDatHang.TabIndex = 7;
			this.buttonDatHang.Text = "Đặt hàng";
			this.buttonDatHang.UseVisualStyleBackColor = true;
			this.buttonDatHang.Click += new System.EventHandler(this.buttonDatHang_Click);
			// 
			// buttonEnd
			// 
			this.buttonEnd.AutoSize = true;
			this.buttonEnd.Location = new System.Drawing.Point(249, 394);
			this.buttonEnd.Name = "buttonEnd";
			this.buttonEnd.Size = new System.Drawing.Size(75, 29);
			this.buttonEnd.TabIndex = 8;
			this.buttonEnd.Text = "Thoát";
			this.buttonEnd.UseVisualStyleBackColor = true;
			this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
			// 
			// groupBoxInfo
			// 
			this.groupBoxInfo.Controls.Add(this.textBoxInfo);
			this.groupBoxInfo.Location = new System.Drawing.Point(401, 12);
			this.groupBoxInfo.Name = "groupBoxInfo";
			this.groupBoxInfo.Size = new System.Drawing.Size(387, 411);
			this.groupBoxInfo.TabIndex = 9;
			this.groupBoxInfo.TabStop = false;
			this.groupBoxInfo.Text = "Thông tin đơn hàng";
			// 
			// textBoxInfo
			// 
			this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxInfo.Location = new System.Drawing.Point(3, 21);
			this.textBoxInfo.Multiline = true;
			this.textBoxInfo.Name = "textBoxInfo";
			this.textBoxInfo.ReadOnly = true;
			this.textBoxInfo.Size = new System.Drawing.Size(381, 387);
			this.textBoxInfo.TabIndex = 0;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// comboBoxRegionPhoneNumber
			// 
			this.comboBoxRegionPhoneNumber.FormattingEnabled = true;
			this.comboBoxRegionPhoneNumber.Items.AddRange(new object[] {
            "+84",
            "+12",
            "+54",
            "+17",
            "+97",
            "+152",
            "+59",
            "+582"});
			this.comboBoxRegionPhoneNumber.Location = new System.Drawing.Point(76, 70);
			this.comboBoxRegionPhoneNumber.Name = "comboBoxRegionPhoneNumber";
			this.comboBoxRegionPhoneNumber.Size = new System.Drawing.Size(66, 25);
			this.comboBoxRegionPhoneNumber.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.comboBoxRegionPhoneNumber);
			this.Controls.Add(this.groupBoxInfo);
			this.Controls.Add(this.buttonEnd);
			this.Controls.Add(this.buttonDatHang);
			this.Controls.Add(this.groupBoxHinhThucTT);
			this.Controls.Add(this.groupBoxDonHang);
			this.Controls.Add(this.textBoxNumberPhone);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelNumberPhone);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelInfo);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBoxDonHang.ResumeLayout(false);
			this.groupBoxHinhThucTT.ResumeLayout(false);
			this.groupBoxInfo.ResumeLayout(false);
			this.groupBoxInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelNumberPhone;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxNumberPhone;
		private System.Windows.Forms.GroupBox groupBoxDonHang;
		private System.Windows.Forms.ListBox listBoxMatHang;
		private System.Windows.Forms.GroupBox groupBoxHinhThucTT;
		private System.Windows.Forms.ComboBox comboBoxHinhThucTT;
		private System.Windows.Forms.Button buttonDatHang;
		private System.Windows.Forms.Button buttonEnd;
		private System.Windows.Forms.GroupBox groupBoxInfo;
		private System.Windows.Forms.TextBox textBoxInfo;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		public System.Windows.Forms.ComboBox comboBoxRegionPhoneNumber;
	}
}

