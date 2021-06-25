
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.labelAge = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelRegDate = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.dateTimePickerReg = new System.Windows.Forms.DateTimePicker();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.labelWarning = new System.Windows.Forms.Label();
			this.labelWar1 = new System.Windows.Forms.Label();
			this.labelWar2 = new System.Windows.Forms.Label();
			this.labelWar3 = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(210, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng ký mua sản phẩm";
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(12, 66);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(33, 15);
			this.labelAge.TabIndex = 1;
			this.labelAge.Text = "Tuổi:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 34);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(46, 15);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Họ tên:";
			// 
			// labelRegDate
			// 
			this.labelRegDate.AutoSize = true;
			this.labelRegDate.Location = new System.Drawing.Point(12, 98);
			this.labelRegDate.Name = "labelRegDate";
			this.labelRegDate.Size = new System.Drawing.Size(83, 15);
			this.labelRegDate.TabIndex = 3;
			this.labelRegDate.Text = "Ngày đăng ký:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(129, 31);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(318, 23);
			this.textBoxName.TabIndex = 4;
			// 
			// textBoxAge
			// 
			this.textBoxAge.Location = new System.Drawing.Point(129, 63);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(318, 23);
			this.textBoxAge.TabIndex = 5;
			// 
			// dateTimePickerReg
			// 
			this.dateTimePickerReg.Location = new System.Drawing.Point(129, 92);
			this.dateTimePickerReg.Name = "dateTimePickerReg";
			this.dateTimePickerReg.Size = new System.Drawing.Size(318, 23);
			this.dateTimePickerReg.TabIndex = 6;
			// 
			// buttonRegister
			// 
			this.buttonRegister.Location = new System.Drawing.Point(129, 140);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(111, 23);
			this.buttonRegister.TabIndex = 7;
			this.buttonRegister.Text = "Đăng Ký";
			this.buttonRegister.UseVisualStyleBackColor = true;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// labelWarning
			// 
			this.labelWarning.AutoSize = true;
			this.labelWarning.Location = new System.Drawing.Point(12, 182);
			this.labelWarning.Name = "labelWarning";
			this.labelWarning.Size = new System.Drawing.Size(41, 15);
			this.labelWarning.TabIndex = 8;
			this.labelWarning.Text = "Chú ý:";
			// 
			// labelWar1
			// 
			this.labelWar1.AutoSize = true;
			this.labelWar1.Location = new System.Drawing.Point(60, 203);
			this.labelWar1.Name = "labelWar1";
			this.labelWar1.Size = new System.Drawing.Size(184, 15);
			this.labelWar1.TabIndex = 9;
			this.labelWar1.Text = "- Họ và tên không được để trống.";
			// 
			// labelWar2
			// 
			this.labelWar2.AutoSize = true;
			this.labelWar2.Location = new System.Drawing.Point(60, 227);
			this.labelWar2.Name = "labelWar2";
			this.labelWar2.Size = new System.Drawing.Size(126, 15);
			this.labelWar2.TabIndex = 10;
			this.labelWar2.Text = "- Tuổi phải lớn hơn 17.";
			// 
			// labelWar3
			// 
			this.labelWar3.AutoSize = true;
			this.labelWar3.Location = new System.Drawing.Point(60, 251);
			this.labelWar3.Name = "labelWar3";
			this.labelWar3.Size = new System.Drawing.Size(196, 15);
			this.labelWar3.TabIndex = 11;
			this.labelWar3.Text = "- Không đăng ký vào ngày chủ nhật";
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelWar3);
			this.Controls.Add(this.labelWar2);
			this.Controls.Add(this.labelWar1);
			this.Controls.Add(this.labelWarning);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.dateTimePickerReg);
			this.Controls.Add(this.textBoxAge);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelRegDate);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelAge);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelRegDate;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.DateTimePicker dateTimePickerReg;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Label labelWarning;
		private System.Windows.Forms.Label labelWar1;
		private System.Windows.Forms.Label labelWar2;
		private System.Windows.Forms.Label labelWar3;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}

