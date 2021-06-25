
namespace TextBox_ComboBox_Button
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
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelDay = new System.Windows.Forms.Label();
			this.labelMonth = new System.Windows.Forms.Label();
			this.labelYear = new System.Windows.Forms.Label();
			this.comboBoxDay = new System.Windows.Forms.ComboBox();
			this.comboBoxMonth = new System.Windows.Forms.ComboBox();
			this.comboBoxYear = new System.Windows.Forms.ComboBox();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(13, 13);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(46, 15);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Họ tên:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(65, 10);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(222, 23);
			this.textBoxName.TabIndex = 1;
			// 
			// labelDay
			// 
			this.labelDay.AutoSize = true;
			this.labelDay.Location = new System.Drawing.Point(13, 53);
			this.labelDay.Name = "labelDay";
			this.labelDay.Size = new System.Drawing.Size(38, 15);
			this.labelDay.TabIndex = 2;
			this.labelDay.Text = "Ngày:";
			// 
			// labelMonth
			// 
			this.labelMonth.AutoSize = true;
			this.labelMonth.Location = new System.Drawing.Point(13, 94);
			this.labelMonth.Name = "labelMonth";
			this.labelMonth.Size = new System.Drawing.Size(43, 15);
			this.labelMonth.TabIndex = 3;
			this.labelMonth.Text = "Tháng:";
			// 
			// labelYear
			// 
			this.labelYear.AutoSize = true;
			this.labelYear.Location = new System.Drawing.Point(13, 134);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(36, 15);
			this.labelYear.TabIndex = 4;
			this.labelYear.Text = "Năm:";
			// 
			// comboBoxDay
			// 
			this.comboBoxDay.FormattingEnabled = true;
			this.comboBoxDay.Location = new System.Drawing.Point(65, 45);
			this.comboBoxDay.Name = "comboBoxDay";
			this.comboBoxDay.Size = new System.Drawing.Size(121, 23);
			this.comboBoxDay.TabIndex = 5;
			// 
			// comboBoxMonth
			// 
			this.comboBoxMonth.FormattingEnabled = true;
			this.comboBoxMonth.Location = new System.Drawing.Point(65, 91);
			this.comboBoxMonth.Name = "comboBoxMonth";
			this.comboBoxMonth.Size = new System.Drawing.Size(121, 23);
			this.comboBoxMonth.TabIndex = 6;
			// 
			// comboBoxYear
			// 
			this.comboBoxYear.FormattingEnabled = true;
			this.comboBoxYear.Location = new System.Drawing.Point(65, 131);
			this.comboBoxYear.Name = "comboBoxYear";
			this.comboBoxYear.Size = new System.Drawing.Size(121, 23);
			this.comboBoxYear.TabIndex = 7;
			// 
			// buttonCheck
			// 
			this.buttonCheck.Location = new System.Drawing.Point(212, 90);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(75, 23);
			this.buttonCheck.TabIndex = 8;
			this.buttonCheck.Text = "&Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCheck);
			this.Controls.Add(this.comboBoxYear);
			this.Controls.Add(this.comboBoxMonth);
			this.Controls.Add(this.comboBoxDay);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelMonth);
			this.Controls.Add(this.labelDay);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelDay;
		private System.Windows.Forms.Label labelMonth;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.ComboBox comboBoxDay;
		private System.Windows.Forms.ComboBox comboBoxMonth;
		private System.Windows.Forms.ComboBox comboBoxYear;
		private System.Windows.Forms.Button buttonCheck;
	}
}

