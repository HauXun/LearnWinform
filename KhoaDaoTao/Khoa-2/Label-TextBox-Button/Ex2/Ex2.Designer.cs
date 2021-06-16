
namespace Ex2
{
	partial class Ex2
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
			this.buttonDisplay = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.textBoxDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonDisplay
			// 
			this.buttonDisplay.Location = new System.Drawing.Point(111, 267);
			this.buttonDisplay.Name = "buttonDisplay";
			this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
			this.buttonDisplay.TabIndex = 0;
			this.buttonDisplay.Text = "Display";
			this.buttonDisplay.UseVisualStyleBackColor = true;
			this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(347, 267);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(599, 267);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// textBoxDisplay
			// 
			this.textBoxDisplay.Location = new System.Drawing.Point(185, 141);
			this.textBoxDisplay.Name = "textBoxDisplay";
			this.textBoxDisplay.ReadOnly = true;
			this.textBoxDisplay.Size = new System.Drawing.Size(414, 23);
			this.textBoxDisplay.TabIndex = 3;
			// 
			// Ex2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxDisplay);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonDisplay);
			this.Name = "Ex2";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonDisplay;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.TextBox textBoxDisplay;
	}
}

