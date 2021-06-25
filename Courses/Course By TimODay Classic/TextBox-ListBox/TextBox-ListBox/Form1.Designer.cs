
namespace TextBox_ListBox
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
			this.listBoxThietBi = new System.Windows.Forms.ListBox();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBoxThietBi
			// 
			this.listBoxThietBi.FormattingEnabled = true;
			this.listBoxThietBi.ItemHeight = 15;
			this.listBoxThietBi.Items.AddRange(new object[] {
            "CPU",
            "RAM",
            "HDD",
            "SDD",
            "MAINBOARD",
            "NIC",
            "MONITOR"});
			this.listBoxThietBi.Location = new System.Drawing.Point(12, 12);
			this.listBoxThietBi.Name = "listBoxThietBi";
			this.listBoxThietBi.Size = new System.Drawing.Size(317, 424);
			this.listBoxThietBi.TabIndex = 0;
			this.listBoxThietBi.Click += new System.EventHandler(this.listBoxThietBi_Click);
			this.listBoxThietBi.SelectedIndexChanged += new System.EventHandler(this.listBoxThietBi_SelectedIndexChanged);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(336, 13);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(452, 23);
			this.textBoxResult.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.listBoxThietBi);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxThietBi;
		private System.Windows.Forms.TextBox textBoxResult;
	}
}

