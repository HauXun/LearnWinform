
namespace ImageGUI
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
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.comboBoxImage = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxImage.ErrorImage = global::ImageGUI.Properties.Resources.TheEndshow;
			this.pictureBoxImage.Location = new System.Drawing.Point(336, 12);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(452, 426);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			// 
			// comboBoxImage
			// 
			this.comboBoxImage.FormattingEnabled = true;
			this.comboBoxImage.Location = new System.Drawing.Point(12, 12);
			this.comboBoxImage.Name = "comboBoxImage";
			this.comboBoxImage.Size = new System.Drawing.Size(318, 23);
			this.comboBoxImage.TabIndex = 1;
			this.comboBoxImage.SelectedValueChanged += new System.EventHandler(this.comboBoxImage_SelectedValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBoxImage);
			this.Controls.Add(this.pictureBoxImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.ComboBox comboBoxImage;
	}
}

