
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
			this.textBoxData = new System.Windows.Forms.TextBox();
			this.labelContent = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonBlue = new System.Windows.Forms.RadioButton();
			this.radioButtonBlack = new System.Windows.Forms.RadioButton();
			this.radioButtonGreen = new System.Windows.Forms.RadioButton();
			this.radioButtonRed = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
			this.checkBoxItalic = new System.Windows.Forms.CheckBox();
			this.checkBoxBold = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxData
			// 
			this.textBoxData.Location = new System.Drawing.Point(99, 13);
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.Size = new System.Drawing.Size(320, 25);
			this.textBoxData.TabIndex = 0;
			// 
			// labelContent
			// 
			this.labelContent.AutoSize = true;
			this.labelContent.Location = new System.Drawing.Point(12, 16);
			this.labelContent.Name = "labelContent";
			this.labelContent.Size = new System.Drawing.Size(69, 19);
			this.labelContent.TabIndex = 1;
			this.labelContent.Text = "Nội dung:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonBlue);
			this.groupBox1.Controls.Add(this.radioButtonBlack);
			this.groupBox1.Controls.Add(this.radioButtonGreen);
			this.groupBox1.Controls.Add(this.radioButtonRed);
			this.groupBox1.Location = new System.Drawing.Point(13, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 155);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu chữ";
			// 
			// radioButtonBlue
			// 
			this.radioButtonBlue.AutoSize = true;
			this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
			this.radioButtonBlue.Location = new System.Drawing.Point(6, 82);
			this.radioButtonBlue.Name = "radioButtonBlue";
			this.radioButtonBlue.Size = new System.Drawing.Size(132, 23);
			this.radioButtonBlue.TabIndex = 3;
			this.radioButtonBlue.TabStop = true;
			this.radioButtonBlue.Text = "Màu xanh dương";
			this.radioButtonBlue.UseVisualStyleBackColor = true;
			this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
			// 
			// radioButtonBlack
			// 
			this.radioButtonBlack.AutoSize = true;
			this.radioButtonBlack.Location = new System.Drawing.Point(6, 111);
			this.radioButtonBlack.Name = "radioButtonBlack";
			this.radioButtonBlack.Size = new System.Drawing.Size(82, 23);
			this.radioButtonBlack.TabIndex = 2;
			this.radioButtonBlack.TabStop = true;
			this.radioButtonBlack.Text = "Màu đen";
			this.radioButtonBlack.UseVisualStyleBackColor = true;
			this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
			// 
			// radioButtonGreen
			// 
			this.radioButtonGreen.AutoSize = true;
			this.radioButtonGreen.ForeColor = System.Drawing.Color.Lime;
			this.radioButtonGreen.Location = new System.Drawing.Point(6, 53);
			this.radioButtonGreen.Name = "radioButtonGreen";
			this.radioButtonGreen.Size = new System.Drawing.Size(102, 23);
			this.radioButtonGreen.TabIndex = 1;
			this.radioButtonGreen.TabStop = true;
			this.radioButtonGreen.Text = "Màu xanh lá";
			this.radioButtonGreen.UseVisualStyleBackColor = true;
			this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
			// 
			// radioButtonRed
			// 
			this.radioButtonRed.AutoSize = true;
			this.radioButtonRed.BackColor = System.Drawing.SystemColors.Control;
			this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
			this.radioButtonRed.Location = new System.Drawing.Point(6, 24);
			this.radioButtonRed.Name = "radioButtonRed";
			this.radioButtonRed.Size = new System.Drawing.Size(75, 23);
			this.radioButtonRed.TabIndex = 0;
			this.radioButtonRed.TabStop = true;
			this.radioButtonRed.Text = "Màu đỏ";
			this.radioButtonRed.UseVisualStyleBackColor = false;
			this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxUnderline);
			this.groupBox2.Controls.Add(this.checkBoxItalic);
			this.groupBox2.Controls.Add(this.checkBoxBold);
			this.groupBox2.Location = new System.Drawing.Point(219, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 155);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chọn kiểu chữ";
			// 
			// checkBoxUnderline
			// 
			this.checkBoxUnderline.AutoSize = true;
			this.checkBoxUnderline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.checkBoxUnderline.Location = new System.Drawing.Point(6, 119);
			this.checkBoxUnderline.Name = "checkBoxUnderline";
			this.checkBoxUnderline.Size = new System.Drawing.Size(119, 23);
			this.checkBoxUnderline.TabIndex = 2;
			this.checkBoxUnderline.Text = "Chữ gạch chân";
			this.checkBoxUnderline.UseVisualStyleBackColor = true;
			this.checkBoxUnderline.CheckedChanged += new System.EventHandler(this.checkBoxUnderline_CheckedChanged);
			// 
			// checkBoxItalic
			// 
			this.checkBoxItalic.AutoSize = true;
			this.checkBoxItalic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.checkBoxItalic.Location = new System.Drawing.Point(6, 70);
			this.checkBoxItalic.Name = "checkBoxItalic";
			this.checkBoxItalic.Size = new System.Drawing.Size(108, 23);
			this.checkBoxItalic.TabIndex = 1;
			this.checkBoxItalic.Text = "Chữ nghiêng";
			this.checkBoxItalic.UseVisualStyleBackColor = true;
			this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
			// 
			// checkBoxBold
			// 
			this.checkBoxBold.AutoSize = true;
			this.checkBoxBold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.checkBoxBold.Location = new System.Drawing.Point(6, 21);
			this.checkBoxBold.Name = "checkBoxBold";
			this.checkBoxBold.Size = new System.Drawing.Size(88, 23);
			this.checkBoxBold.TabIndex = 0;
			this.checkBoxBold.Text = "Chữ đậm";
			this.checkBoxBold.UseVisualStyleBackColor = true;
			this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelContent);
			this.Controls.Add(this.textBoxData);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxData;
		private System.Windows.Forms.Label labelContent;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButtonBlue;
		private System.Windows.Forms.RadioButton radioButtonBlack;
		private System.Windows.Forms.RadioButton radioButtonGreen;
		private System.Windows.Forms.RadioButton radioButtonRed;
		private System.Windows.Forms.CheckBox checkBoxUnderline;
		private System.Windows.Forms.CheckBox checkBoxItalic;
		private System.Windows.Forms.CheckBox checkBoxBold;
	}
}

