
namespace LabelGUI
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HaiZu = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HaiZu
			// 
			this.HaiZu.AutoSize = true;
			this.HaiZu.Location = new System.Drawing.Point(358, 205);
			this.HaiZu.Name = "HaiZu";
			this.HaiZu.Size = new System.Drawing.Size(58, 15);
			this.HaiZu.TabIndex = 0;
			this.HaiZu.Text = "Hai Zụ nè";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.HaiZu);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label HaiZu;
	}
}