
namespace Proxy
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cbAdmin = new System.Windows.Forms.CheckBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(191, 23);
			this.textBox1.TabIndex = 0;
			// 
			// cbAdmin
			// 
			this.cbAdmin.AutoSize = true;
			this.cbAdmin.Location = new System.Drawing.Point(209, 16);
			this.cbAdmin.Name = "cbAdmin";
			this.cbAdmin.Size = new System.Drawing.Size(62, 19);
			this.cbAdmin.TabIndex = 1;
			this.cbAdmin.Text = "Admin";
			this.cbAdmin.UseVisualStyleBackColor = true;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(299, 11);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 2;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.cbAdmin);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbAdmin;
		private System.Windows.Forms.Button btnCheck;
	}
}

