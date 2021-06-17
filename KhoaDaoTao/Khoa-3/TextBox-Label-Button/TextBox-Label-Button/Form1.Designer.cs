
namespace TextBox_Label_Button
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
			this.textBoxDisplay = new System.Windows.Forms.TextBox();
			this.buttonView = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxDisplay
			// 
			this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
			this.textBoxDisplay.Multiline = true;
			this.textBoxDisplay.Name = "textBoxDisplay";
			this.textBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDisplay.Size = new System.Drawing.Size(776, 62);
			this.textBoxDisplay.TabIndex = 0;
			this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
			// 
			// buttonView
			// 
			this.buttonView.Enabled = false;
			this.buttonView.Location = new System.Drawing.Point(547, 80);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(75, 23);
			this.buttonView.TabIndex = 1;
			this.buttonView.Text = "&View";
			this.buttonView.UseVisualStyleBackColor = true;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(667, 80);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "&Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelDisplay
			// 
			this.labelDisplay.AutoSize = true;
			this.labelDisplay.Location = new System.Drawing.Point(13, 80);
			this.labelDisplay.Name = "labelDisplay";
			this.labelDisplay.Size = new System.Drawing.Size(38, 15);
			this.labelDisplay.TabIndex = 3;
			this.labelDisplay.Text = "label1";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonView;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelDisplay);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonView);
			this.Controls.Add(this.textBoxDisplay);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxDisplay;
		private System.Windows.Forms.Button buttonView;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelDisplay;
	}
}

