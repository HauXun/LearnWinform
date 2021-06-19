
namespace MDINotepad
{
	partial class formNotepad
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
			this.rtbNotepad = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbNotepad
			// 
			this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
			this.rtbNotepad.Name = "rtbNotepad";
			this.rtbNotepad.Size = new System.Drawing.Size(800, 450);
			this.rtbNotepad.TabIndex = 0;
			this.rtbNotepad.Text = "";
			// 
			// formNotepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtbNotepad);
			this.Name = "formNotepad";
			this.Text = "Untitled 1";
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.RichTextBox rtbNotepad;
	}
}