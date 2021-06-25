
namespace ProcessGUI
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
			this.buttonProcess = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonHidden = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(644, 426);
			this.textBox1.TabIndex = 0;
			// 
			// buttonProcess
			// 
			this.buttonProcess.Location = new System.Drawing.Point(662, 12);
			this.buttonProcess.Name = "buttonProcess";
			this.buttonProcess.Size = new System.Drawing.Size(126, 23);
			this.buttonProcess.TabIndex = 1;
			this.buttonProcess.Text = "Get Process";
			this.buttonProcess.UseVisualStyleBackColor = true;
			this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(662, 41);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(126, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Start Process";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonHidden
			// 
			this.buttonHidden.Location = new System.Drawing.Point(662, 70);
			this.buttonHidden.Name = "buttonHidden";
			this.buttonHidden.Size = new System.Drawing.Size(126, 23);
			this.buttonHidden.TabIndex = 3;
			this.buttonHidden.Text = "Hidden";
			this.buttonHidden.UseVisualStyleBackColor = true;
			this.buttonHidden.Click += new System.EventHandler(this.buttonHidden_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonHidden);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.buttonProcess);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonProcess;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonHidden;
	}
}

