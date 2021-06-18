
namespace Label_GroupBox_RadioButton
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonNewLine = new System.Windows.Forms.RadioButton();
			this.radioButtonInHoa = new System.Windows.Forms.RadioButton();
			this.radioButtonBoldText = new System.Windows.Forms.RadioButton();
			this.radioButtonItalicText = new System.Windows.Forms.RadioButton();
			this.labelResult = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thuộc tính MultiLine để làm gì ?";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonNewLine);
			this.groupBox1.Controls.Add(this.radioButtonInHoa);
			this.groupBox1.Controls.Add(this.radioButtonBoldText);
			this.groupBox1.Controls.Add(this.radioButtonItalicText);
			this.groupBox1.Location = new System.Drawing.Point(12, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(428, 145);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Trả lời";
			// 
			// radioButtonNewLine
			// 
			this.radioButtonNewLine.AutoSize = true;
			this.radioButtonNewLine.Location = new System.Drawing.Point(316, 37);
			this.radioButtonNewLine.Name = "radioButtonNewLine";
			this.radioButtonNewLine.Size = new System.Drawing.Size(91, 19);
			this.radioButtonNewLine.TabIndex = 3;
			this.radioButtonNewLine.Text = "Xuống dòng";
			this.radioButtonNewLine.UseVisualStyleBackColor = true;
			// 
			// radioButtonInHoa
			// 
			this.radioButtonInHoa.AutoSize = true;
			this.radioButtonInHoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.radioButtonInHoa.Location = new System.Drawing.Point(316, 92);
			this.radioButtonInHoa.Name = "radioButtonInHoa";
			this.radioButtonInHoa.Size = new System.Drawing.Size(85, 19);
			this.radioButtonInHoa.TabIndex = 2;
			this.radioButtonInHoa.Text = "Chữ In Hoa";
			this.radioButtonInHoa.UseVisualStyleBackColor = true;
			// 
			// radioButtonBoldText
			// 
			this.radioButtonBoldText.AutoSize = true;
			this.radioButtonBoldText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonBoldText.Location = new System.Drawing.Point(23, 92);
			this.radioButtonBoldText.Name = "radioButtonBoldText";
			this.radioButtonBoldText.Size = new System.Drawing.Size(76, 19);
			this.radioButtonBoldText.TabIndex = 1;
			this.radioButtonBoldText.Text = "Chữ Đậm";
			this.radioButtonBoldText.UseVisualStyleBackColor = true;
			// 
			// radioButtonItalicText
			// 
			this.radioButtonItalicText.AutoSize = true;
			this.radioButtonItalicText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.radioButtonItalicText.Location = new System.Drawing.Point(23, 37);
			this.radioButtonItalicText.Name = "radioButtonItalicText";
			this.radioButtonItalicText.Size = new System.Drawing.Size(94, 19);
			this.radioButtonItalicText.TabIndex = 0;
			this.radioButtonItalicText.Text = "Chữ nghiêng";
			this.radioButtonItalicText.UseVisualStyleBackColor = true;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(12, 190);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(0, 15);
			this.labelResult.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Có súng đây nè!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonNewLine;
		private System.Windows.Forms.RadioButton radioButtonInHoa;
		private System.Windows.Forms.RadioButton radioButtonBoldText;
		private System.Windows.Forms.RadioButton radioButtonItalicText;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label label2;
	}
}

