
namespace Ex1
{
	partial class Ex1
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
			this.buttonGreen = new System.Windows.Forms.Button();
			this.buttonYellow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonGreen
			// 
			this.buttonGreen.Location = new System.Drawing.Point(143, 156);
			this.buttonGreen.Name = "buttonGreen";
			this.buttonGreen.Size = new System.Drawing.Size(75, 23);
			this.buttonGreen.TabIndex = 0;
			this.buttonGreen.Text = "Green";
			this.buttonGreen.UseVisualStyleBackColor = true;
			this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
			// 
			// buttonYellow
			// 
			this.buttonYellow.Location = new System.Drawing.Point(581, 156);
			this.buttonYellow.Name = "buttonYellow";
			this.buttonYellow.Size = new System.Drawing.Size(75, 23);
			this.buttonYellow.TabIndex = 1;
			this.buttonYellow.Text = "Yellow";
			this.buttonYellow.UseVisualStyleBackColor = true;
			this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
			// 
			// Ex1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonYellow);
			this.Controls.Add(this.buttonGreen);
			this.Name = "Ex1";
			this.Text = "Color Treatment";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonGreen;
		private System.Windows.Forms.Button buttonYellow;
	}
}

