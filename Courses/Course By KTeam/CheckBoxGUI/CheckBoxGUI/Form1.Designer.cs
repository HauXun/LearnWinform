
namespace CheckBoxGUI
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
			this.checkBox3Soc = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.buttonClick = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox3Soc
			// 
			this.checkBox3Soc.AutoSize = true;
			this.checkBox3Soc.Checked = true;
			this.checkBox3Soc.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBox3Soc.Location = new System.Drawing.Point(154, 119);
			this.checkBox3Soc.Name = "checkBox3Soc";
			this.checkBox3Soc.Size = new System.Drawing.Size(137, 19);
			this.checkBox3Soc.TabIndex = 0;
			this.checkBox3Soc.Text = "Bạn có 3 sọc không ?";
			this.checkBox3Soc.ThreeState = true;
			this.checkBox3Soc.UseVisualStyleBackColor = true;
			this.checkBox3Soc.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox3Soc.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
			this.checkBox3Soc.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(154, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên của mày";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(154, 90);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 23);
			this.textBoxName.TabIndex = 2;
			// 
			// buttonClick
			// 
			this.buttonClick.Location = new System.Drawing.Point(154, 145);
			this.buttonClick.Name = "buttonClick";
			this.buttonClick.Size = new System.Drawing.Size(75, 23);
			this.buttonClick.TabIndex = 3;
			this.buttonClick.Text = "Click";
			this.buttonClick.UseVisualStyleBackColor = true;
			this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonClick);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox3Soc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox3Soc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonClick;
	}
}

