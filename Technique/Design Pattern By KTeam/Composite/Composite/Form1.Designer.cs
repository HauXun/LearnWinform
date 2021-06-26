
namespace Composite
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
			this.nudDai = new System.Windows.Forms.NumericUpDown();
			this.nudRong = new System.Windows.Forms.NumericUpDown();
			this.nudBanKinh = new System.Windows.Forms.NumericUpDown();
			this.cbHCN = new System.Windows.Forms.CheckBox();
			this.cbHinhTron = new System.Windows.Forms.CheckBox();
			this.buttona1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudDai)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBanKinh)).BeginInit();
			this.SuspendLayout();
			// 
			// nudDai
			// 
			this.nudDai.Location = new System.Drawing.Point(12, 12);
			this.nudDai.Name = "nudDai";
			this.nudDai.Size = new System.Drawing.Size(64, 23);
			this.nudDai.TabIndex = 0;
			// 
			// nudRong
			// 
			this.nudRong.Location = new System.Drawing.Point(82, 12);
			this.nudRong.Name = "nudRong";
			this.nudRong.Size = new System.Drawing.Size(64, 23);
			this.nudRong.TabIndex = 1;
			// 
			// nudBanKinh
			// 
			this.nudBanKinh.Location = new System.Drawing.Point(12, 41);
			this.nudBanKinh.Name = "nudBanKinh";
			this.nudBanKinh.Size = new System.Drawing.Size(64, 23);
			this.nudBanKinh.TabIndex = 2;
			// 
			// cbHCN
			// 
			this.cbHCN.AutoSize = true;
			this.cbHCN.Location = new System.Drawing.Point(152, 13);
			this.cbHCN.Name = "cbHCN";
			this.cbHCN.Size = new System.Drawing.Size(102, 19);
			this.cbHCN.TabIndex = 3;
			this.cbHCN.Text = "Hình chữ nhật";
			this.cbHCN.UseVisualStyleBackColor = true;
			this.cbHCN.CheckedChanged += new System.EventHandler(this.cbHinhTron_CheckedChanged);
			// 
			// cbHinhTron
			// 
			this.cbHinhTron.AutoSize = true;
			this.cbHinhTron.Location = new System.Drawing.Point(153, 42);
			this.cbHinhTron.Name = "cbHinhTron";
			this.cbHinhTron.Size = new System.Drawing.Size(102, 19);
			this.cbHinhTron.TabIndex = 4;
			this.cbHinhTron.Text = "Hình chữ nhật";
			this.cbHinhTron.UseVisualStyleBackColor = true;
			this.cbHinhTron.CheckedChanged += new System.EventHandler(this.cbHinhTron_CheckedChanged);
			// 
			// buttona1
			// 
			this.buttona1.AccessibleDescription = "btnTheTich";
			this.buttona1.Location = new System.Drawing.Point(275, 10);
			this.buttona1.Name = "buttona1";
			this.buttona1.Size = new System.Drawing.Size(75, 23);
			this.buttona1.TabIndex = 5;
			this.buttona1.Text = "Thể tích";
			this.buttona1.UseVisualStyleBackColor = true;
			this.buttona1.Click += new System.EventHandler(this.buttona1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttona1);
			this.Controls.Add(this.cbHinhTron);
			this.Controls.Add(this.cbHCN);
			this.Controls.Add(this.nudBanKinh);
			this.Controls.Add(this.nudRong);
			this.Controls.Add(this.nudDai);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudDai)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBanKinh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudDai;
		private System.Windows.Forms.NumericUpDown nudRong;
		private System.Windows.Forms.NumericUpDown nudBanKinh;
		private System.Windows.Forms.CheckBox cbHCN;
		private System.Windows.Forms.CheckBox cbHinhTron;
		private System.Windows.Forms.Button buttona1;
	}
}

