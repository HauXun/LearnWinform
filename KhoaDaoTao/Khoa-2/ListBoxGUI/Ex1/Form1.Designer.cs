
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
			this.buttonInput = new System.Windows.Forms.Button();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.labelInput = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxNumber = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonChangeWithDouble = new System.Windows.Forms.Button();
			this.buttonGetOddNumber = new System.Windows.Forms.Button();
			this.buttonGetEvenNumber = new System.Windows.Forms.Button();
			this.buttonIncreaseTwice = new System.Windows.Forms.Button();
			this.buttonRemoveSelected = new System.Windows.Forms.Button();
			this.buttonRemoveHeadTail = new System.Windows.Forms.Button();
			this.buttonSum = new System.Windows.Forms.Button();
			this.buttonEnd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonInput
			// 
			this.buttonInput.AutoSize = true;
			this.buttonInput.Location = new System.Drawing.Point(375, 12);
			this.buttonInput.Name = "buttonInput";
			this.buttonInput.Size = new System.Drawing.Size(75, 29);
			this.buttonInput.TabIndex = 0;
			this.buttonInput.Text = "Nhập";
			this.buttonInput.UseVisualStyleBackColor = true;
			this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(139, 14);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(207, 25);
			this.textBoxInput.TabIndex = 1;
			// 
			// labelInput
			// 
			this.labelInput.AutoSize = true;
			this.labelInput.Location = new System.Drawing.Point(12, 17);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(63, 19);
			this.labelInput.TabIndex = 2;
			this.labelInput.Text = "Nhập số:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxNumber);
			this.groupBox1.Location = new System.Drawing.Point(12, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(211, 299);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách hiển thị:";
			// 
			// listBoxNumber
			// 
			this.listBoxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxNumber.FormattingEnabled = true;
			this.listBoxNumber.ItemHeight = 17;
			this.listBoxNumber.Location = new System.Drawing.Point(3, 21);
			this.listBoxNumber.Name = "listBoxNumber";
			this.listBoxNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxNumber.Size = new System.Drawing.Size(205, 275);
			this.listBoxNumber.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonChangeWithDouble);
			this.groupBox2.Controls.Add(this.buttonGetOddNumber);
			this.groupBox2.Controls.Add(this.buttonGetEvenNumber);
			this.groupBox2.Controls.Add(this.buttonIncreaseTwice);
			this.groupBox2.Controls.Add(this.buttonRemoveSelected);
			this.groupBox2.Controls.Add(this.buttonRemoveHeadTail);
			this.groupBox2.Controls.Add(this.buttonSum);
			this.groupBox2.Location = new System.Drawing.Point(229, 47);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(221, 294);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng:";
			// 
			// buttonChangeWithDouble
			// 
			this.buttonChangeWithDouble.AutoSize = true;
			this.buttonChangeWithDouble.Location = new System.Drawing.Point(10, 174);
			this.buttonChangeWithDouble.Name = "buttonChangeWithDouble";
			this.buttonChangeWithDouble.Size = new System.Drawing.Size(205, 29);
			this.buttonChangeWithDouble.TabIndex = 4;
			this.buttonChangeWithDouble.Text = "Bình phương mỗi giá trị";
			this.buttonChangeWithDouble.UseVisualStyleBackColor = true;
			this.buttonChangeWithDouble.Click += new System.EventHandler(this.buttonChangeWithDouble_Click);
			// 
			// buttonGetOddNumber
			// 
			this.buttonGetOddNumber.AutoSize = true;
			this.buttonGetOddNumber.Location = new System.Drawing.Point(10, 244);
			this.buttonGetOddNumber.Name = "buttonGetOddNumber";
			this.buttonGetOddNumber.Size = new System.Drawing.Size(205, 29);
			this.buttonGetOddNumber.TabIndex = 6;
			this.buttonGetOddNumber.Text = "Chọn số lẻ";
			this.buttonGetOddNumber.UseVisualStyleBackColor = true;
			this.buttonGetOddNumber.Click += new System.EventHandler(this.buttonGetOddNumber_Click);
			// 
			// buttonGetEvenNumber
			// 
			this.buttonGetEvenNumber.AutoSize = true;
			this.buttonGetEvenNumber.Location = new System.Drawing.Point(10, 209);
			this.buttonGetEvenNumber.Name = "buttonGetEvenNumber";
			this.buttonGetEvenNumber.Size = new System.Drawing.Size(205, 29);
			this.buttonGetEvenNumber.TabIndex = 5;
			this.buttonGetEvenNumber.Text = "Chọn số chẵn";
			this.buttonGetEvenNumber.UseVisualStyleBackColor = true;
			this.buttonGetEvenNumber.Click += new System.EventHandler(this.buttonGetEvenNumber_Click);
			// 
			// buttonIncreaseTwice
			// 
			this.buttonIncreaseTwice.AutoSize = true;
			this.buttonIncreaseTwice.Location = new System.Drawing.Point(10, 139);
			this.buttonIncreaseTwice.Name = "buttonIncreaseTwice";
			this.buttonIncreaseTwice.Size = new System.Drawing.Size(205, 29);
			this.buttonIncreaseTwice.TabIndex = 3;
			this.buttonIncreaseTwice.Text = "Tăng mỗi phần tử lên 2 lần";
			this.buttonIncreaseTwice.UseVisualStyleBackColor = true;
			this.buttonIncreaseTwice.Click += new System.EventHandler(this.buttonIncreaseTwice_Click);
			// 
			// buttonRemoveSelected
			// 
			this.buttonRemoveSelected.AutoSize = true;
			this.buttonRemoveSelected.Location = new System.Drawing.Point(10, 104);
			this.buttonRemoveSelected.Name = "buttonRemoveSelected";
			this.buttonRemoveSelected.Size = new System.Drawing.Size(205, 29);
			this.buttonRemoveSelected.TabIndex = 2;
			this.buttonRemoveSelected.Text = "Xóa phần tử đang chọn";
			this.buttonRemoveSelected.UseVisualStyleBackColor = true;
			this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
			// 
			// buttonRemoveHeadTail
			// 
			this.buttonRemoveHeadTail.AutoSize = true;
			this.buttonRemoveHeadTail.Location = new System.Drawing.Point(10, 69);
			this.buttonRemoveHeadTail.Name = "buttonRemoveHeadTail";
			this.buttonRemoveHeadTail.Size = new System.Drawing.Size(205, 29);
			this.buttonRemoveHeadTail.TabIndex = 1;
			this.buttonRemoveHeadTail.Text = "Xóa phần tử đầu và cuối";
			this.buttonRemoveHeadTail.UseVisualStyleBackColor = true;
			this.buttonRemoveHeadTail.Click += new System.EventHandler(this.buttonRemoveHeadTail_Click);
			// 
			// buttonSum
			// 
			this.buttonSum.AutoSize = true;
			this.buttonSum.Location = new System.Drawing.Point(10, 34);
			this.buttonSum.Name = "buttonSum";
			this.buttonSum.Size = new System.Drawing.Size(205, 29);
			this.buttonSum.TabIndex = 0;
			this.buttonSum.Text = "Tổng danh sách";
			this.buttonSum.UseVisualStyleBackColor = true;
			this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
			// 
			// buttonEnd
			// 
			this.buttonEnd.AutoSize = true;
			this.buttonEnd.Location = new System.Drawing.Point(163, 347);
			this.buttonEnd.Name = "buttonEnd";
			this.buttonEnd.Size = new System.Drawing.Size(116, 29);
			this.buttonEnd.TabIndex = 7;
			this.buttonEnd.Text = "Kết thúc";
			this.buttonEnd.UseVisualStyleBackColor = true;
			this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonInput;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 510);
			this.Controls.Add(this.buttonEnd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelInput);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.buttonInput);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonInput;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBoxNumber;
		private System.Windows.Forms.Button buttonChangeWithDouble;
		private System.Windows.Forms.Button buttonGetOddNumber;
		private System.Windows.Forms.Button buttonGetEvenNumber;
		private System.Windows.Forms.Button buttonIncreaseTwice;
		private System.Windows.Forms.Button buttonRemoveSelected;
		private System.Windows.Forms.Button buttonRemoveHeadTail;
		private System.Windows.Forms.Button buttonSum;
		private System.Windows.Forms.Button buttonEnd;
	}
}

