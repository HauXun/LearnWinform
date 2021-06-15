
namespace LinQGUI
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
			this.comboBoxData = new System.Windows.Forms.ComboBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxKey = new System.Windows.Forms.TextBox();
			this.comboBoxResult = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBoxData
			// 
			this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBoxData.FormattingEnabled = true;
			this.comboBoxData.Location = new System.Drawing.Point(12, 44);
			this.comboBoxData.Name = "comboBoxData";
			this.comboBoxData.Size = new System.Drawing.Size(186, 150);
			this.comboBoxData.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(292, 12);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(92, 23);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Filter";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxKey
			// 
			this.textBoxKey.Location = new System.Drawing.Point(13, 13);
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.Size = new System.Drawing.Size(273, 23);
			this.textBoxKey.TabIndex = 2;
			// 
			// comboBoxResult
			// 
			this.comboBoxResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBoxResult.FormattingEnabled = true;
			this.comboBoxResult.Location = new System.Drawing.Point(204, 44);
			this.comboBoxResult.Name = "comboBoxResult";
			this.comboBoxResult.Size = new System.Drawing.Size(180, 150);
			this.comboBoxResult.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 561);
			this.Controls.Add(this.comboBoxResult);
			this.Controls.Add(this.textBoxKey);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxData);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxData;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.ComboBox comboBoxResult;
	}
}

