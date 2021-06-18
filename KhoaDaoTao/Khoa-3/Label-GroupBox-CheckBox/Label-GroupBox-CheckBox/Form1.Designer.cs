
namespace Label_GroupBox_CheckBox
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
			this.groupBoxSelect = new System.Windows.Forms.GroupBox();
			this.checkBoxHV = new System.Windows.Forms.CheckBox();
			this.checkBoxCN = new System.Windows.Forms.CheckBox();
			this.checkBoxHT = new System.Windows.Forms.CheckBox();
			this.checkBoxThoi = new System.Windows.Forms.CheckBox();
			this.checkBoxHBE = new System.Windows.Forms.CheckBox();
			this.checkBoxHTG = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.groupBoxSelect.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxSelect
			// 
			this.groupBoxSelect.Controls.Add(this.checkBoxHTG);
			this.groupBoxSelect.Controls.Add(this.checkBoxHBE);
			this.groupBoxSelect.Controls.Add(this.checkBoxThoi);
			this.groupBoxSelect.Controls.Add(this.checkBoxHT);
			this.groupBoxSelect.Controls.Add(this.checkBoxCN);
			this.groupBoxSelect.Controls.Add(this.checkBoxHV);
			this.groupBoxSelect.Location = new System.Drawing.Point(12, 12);
			this.groupBoxSelect.Name = "groupBoxSelect";
			this.groupBoxSelect.Size = new System.Drawing.Size(510, 179);
			this.groupBoxSelect.TabIndex = 0;
			this.groupBoxSelect.TabStop = false;
			this.groupBoxSelect.Text = "Chọn các loại Hình học";
			// 
			// checkBoxHV
			// 
			this.checkBoxHV.AutoSize = true;
			this.checkBoxHV.Location = new System.Drawing.Point(27, 23);
			this.checkBoxHV.Name = "checkBoxHV";
			this.checkBoxHV.Size = new System.Drawing.Size(90, 19);
			this.checkBoxHV.TabIndex = 0;
			this.checkBoxHV.Text = "Hình Vuông";
			this.checkBoxHV.UseVisualStyleBackColor = true;
			// 
			// checkBoxCN
			// 
			this.checkBoxCN.AutoSize = true;
			this.checkBoxCN.Location = new System.Drawing.Point(27, 114);
			this.checkBoxCN.Name = "checkBoxCN";
			this.checkBoxCN.Size = new System.Drawing.Size(106, 19);
			this.checkBoxCN.TabIndex = 1;
			this.checkBoxCN.Text = "Hình Chữ Nhật";
			this.checkBoxCN.UseVisualStyleBackColor = true;
			// 
			// checkBoxHT
			// 
			this.checkBoxHT.AutoSize = true;
			this.checkBoxHT.Location = new System.Drawing.Point(208, 23);
			this.checkBoxHT.Name = "checkBoxHT";
			this.checkBoxHT.Size = new System.Drawing.Size(78, 19);
			this.checkBoxHT.TabIndex = 2;
			this.checkBoxHT.Text = "Hình Tròn";
			this.checkBoxHT.UseVisualStyleBackColor = true;
			// 
			// checkBoxThoi
			// 
			this.checkBoxThoi.AutoSize = true;
			this.checkBoxThoi.Location = new System.Drawing.Point(208, 114);
			this.checkBoxThoi.Name = "checkBoxThoi";
			this.checkBoxThoi.Size = new System.Drawing.Size(78, 19);
			this.checkBoxThoi.TabIndex = 3;
			this.checkBoxThoi.Text = "Hình Thoi";
			this.checkBoxThoi.UseVisualStyleBackColor = true;
			// 
			// checkBoxHBE
			// 
			this.checkBoxHBE.AutoSize = true;
			this.checkBoxHBE.Location = new System.Drawing.Point(379, 114);
			this.checkBoxHBE.Name = "checkBoxHBE";
			this.checkBoxHBE.Size = new System.Drawing.Size(106, 19);
			this.checkBoxHBE.TabIndex = 4;
			this.checkBoxHBE.Text = "Hình bóng em!";
			this.checkBoxHBE.UseVisualStyleBackColor = true;
			// 
			// checkBoxHTG
			// 
			this.checkBoxHTG.AutoSize = true;
			this.checkBoxHTG.Location = new System.Drawing.Point(379, 23);
			this.checkBoxHTG.Name = "checkBoxHTG";
			this.checkBoxHTG.Size = new System.Drawing.Size(103, 19);
			this.checkBoxHTG.TabIndex = 5;
			this.checkBoxHTG.Text = "Hình Tam Giác";
			this.checkBoxHTG.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(39, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Xem";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(12, 288);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(0, 15);
			this.labelResult.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBoxSelect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBoxSelect.ResumeLayout(false);
			this.groupBoxSelect.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxSelect;
		private System.Windows.Forms.CheckBox checkBoxHTG;
		private System.Windows.Forms.CheckBox checkBoxHBE;
		private System.Windows.Forms.CheckBox checkBoxThoi;
		private System.Windows.Forms.CheckBox checkBoxHT;
		private System.Windows.Forms.CheckBox checkBoxCN;
		private System.Windows.Forms.CheckBox checkBoxHV;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelResult;
	}
}

