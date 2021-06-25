
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
			this.pictureBoxOn = new System.Windows.Forms.PictureBox();
			this.pictureBoxOff = new System.Windows.Forms.PictureBox();
			this.buttonOnOff = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxOn
			// 
			this.pictureBoxOn.Image = global::Ex1.Properties.Resources.TheGathering;
			this.pictureBoxOn.Location = new System.Drawing.Point(300, 68);
			this.pictureBoxOn.Name = "pictureBoxOn";
			this.pictureBoxOn.Size = new System.Drawing.Size(199, 251);
			this.pictureBoxOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxOn.TabIndex = 0;
			this.pictureBoxOn.TabStop = false;
			// 
			// pictureBoxOff
			// 
			this.pictureBoxOff.Image = global::Ex1.Properties.Resources.TheClosingCeremory;
			this.pictureBoxOff.Location = new System.Drawing.Point(300, 68);
			this.pictureBoxOff.Name = "pictureBoxOff";
			this.pictureBoxOff.Size = new System.Drawing.Size(199, 251);
			this.pictureBoxOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxOff.TabIndex = 1;
			this.pictureBoxOff.TabStop = false;
			// 
			// buttonOnOff
			// 
			this.buttonOnOff.AutoSize = true;
			this.buttonOnOff.Location = new System.Drawing.Point(300, 325);
			this.buttonOnOff.Name = "buttonOnOff";
			this.buttonOnOff.Size = new System.Drawing.Size(116, 30);
			this.buttonOnOff.TabIndex = 2;
			this.buttonOnOff.UseVisualStyleBackColor = true;
			this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonOnOff);
			this.Controls.Add(this.pictureBoxOff);
			this.Controls.Add(this.pictureBoxOn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxOn;
		private System.Windows.Forms.PictureBox pictureBoxOff;
		private System.Windows.Forms.Button buttonOnOff;
	}
}

