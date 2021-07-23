
namespace Serialize_Deserialize
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSerialize = new System.Windows.Forms.Button();
			this.btnDesrialize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 13);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add new";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSerialize
			// 
			this.btnSerialize.Location = new System.Drawing.Point(94, 13);
			this.btnSerialize.Name = "btnSerialize";
			this.btnSerialize.Size = new System.Drawing.Size(75, 23);
			this.btnSerialize.TabIndex = 1;
			this.btnSerialize.Text = "Serialize";
			this.btnSerialize.UseVisualStyleBackColor = true;
			this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
			// 
			// btnDesrialize
			// 
			this.btnDesrialize.Location = new System.Drawing.Point(12, 43);
			this.btnDesrialize.Name = "btnDesrialize";
			this.btnDesrialize.Size = new System.Drawing.Size(75, 23);
			this.btnDesrialize.TabIndex = 2;
			this.btnDesrialize.Text = "Desrialize";
			this.btnDesrialize.UseVisualStyleBackColor = true;
			this.btnDesrialize.Click += new System.EventHandler(this.btnDesrialize_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDesrialize);
			this.Controls.Add(this.btnSerialize);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSerialize;
		private System.Windows.Forms.Button btnDesrialize;
	}
}

