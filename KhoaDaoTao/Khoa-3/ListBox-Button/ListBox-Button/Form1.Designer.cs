
namespace ListBox_Button
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
			this.groupBoxListMH = new System.Windows.Forms.GroupBox();
			this.listBoxMatHang = new System.Windows.Forms.ListBox();
			this.groupBoxSelected = new System.Windows.Forms.GroupBox();
			this.listBoxSelected = new System.Windows.Forms.ListBox();
			this.buttonPutOne = new System.Windows.Forms.Button();
			this.buttonPutAll = new System.Windows.Forms.Button();
			this.buttonRemoveOne = new System.Windows.Forms.Button();
			this.buttonRemoveAll = new System.Windows.Forms.Button();
			this.groupBoxListMH.SuspendLayout();
			this.groupBoxSelected.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxListMH
			// 
			this.groupBoxListMH.Controls.Add(this.listBoxMatHang);
			this.groupBoxListMH.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBoxListMH.Location = new System.Drawing.Point(0, 0);
			this.groupBoxListMH.Name = "groupBoxListMH";
			this.groupBoxListMH.Size = new System.Drawing.Size(333, 450);
			this.groupBoxListMH.TabIndex = 0;
			this.groupBoxListMH.TabStop = false;
			this.groupBoxListMH.Text = "Danh sách các mặt hàng:";
			// 
			// listBoxMatHang
			// 
			this.listBoxMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxMatHang.FormattingEnabled = true;
			this.listBoxMatHang.ItemHeight = 15;
			this.listBoxMatHang.Items.AddRange(new object[] {
            "CPU",
            "RAM",
            "HDD",
            "SDD",
            "MAINBOARD",
            "CASE",
            "FAN",
            "MOUSE",
            "DISPLAY",
            "KEYBOARD"});
			this.listBoxMatHang.Location = new System.Drawing.Point(3, 19);
			this.listBoxMatHang.Name = "listBoxMatHang";
			this.listBoxMatHang.Size = new System.Drawing.Size(327, 428);
			this.listBoxMatHang.TabIndex = 0;
			// 
			// groupBoxSelected
			// 
			this.groupBoxSelected.Controls.Add(this.listBoxSelected);
			this.groupBoxSelected.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBoxSelected.Location = new System.Drawing.Point(456, 0);
			this.groupBoxSelected.Name = "groupBoxSelected";
			this.groupBoxSelected.Size = new System.Drawing.Size(344, 450);
			this.groupBoxSelected.TabIndex = 1;
			this.groupBoxSelected.TabStop = false;
			this.groupBoxSelected.Text = "Các mặt hàng lựa chọn:";
			// 
			// listBoxSelected
			// 
			this.listBoxSelected.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxSelected.FormattingEnabled = true;
			this.listBoxSelected.ItemHeight = 15;
			this.listBoxSelected.Location = new System.Drawing.Point(3, 19);
			this.listBoxSelected.Name = "listBoxSelected";
			this.listBoxSelected.Size = new System.Drawing.Size(338, 428);
			this.listBoxSelected.TabIndex = 1;
			// 
			// buttonPutOne
			// 
			this.buttonPutOne.Location = new System.Drawing.Point(356, 142);
			this.buttonPutOne.Name = "buttonPutOne";
			this.buttonPutOne.Size = new System.Drawing.Size(75, 23);
			this.buttonPutOne.TabIndex = 2;
			this.buttonPutOne.Text = ">";
			this.buttonPutOne.UseVisualStyleBackColor = true;
			this.buttonPutOne.Click += new System.EventHandler(this.buttonPutOne_Click);
			// 
			// buttonPutAll
			// 
			this.buttonPutAll.Location = new System.Drawing.Point(356, 197);
			this.buttonPutAll.Name = "buttonPutAll";
			this.buttonPutAll.Size = new System.Drawing.Size(75, 23);
			this.buttonPutAll.TabIndex = 3;
			this.buttonPutAll.Text = ">>";
			this.buttonPutAll.UseVisualStyleBackColor = true;
			this.buttonPutAll.Click += new System.EventHandler(this.buttonPutAll_Click);
			// 
			// buttonRemoveOne
			// 
			this.buttonRemoveOne.Location = new System.Drawing.Point(356, 251);
			this.buttonRemoveOne.Name = "buttonRemoveOne";
			this.buttonRemoveOne.Size = new System.Drawing.Size(75, 23);
			this.buttonRemoveOne.TabIndex = 4;
			this.buttonRemoveOne.Text = "<";
			this.buttonRemoveOne.UseVisualStyleBackColor = true;
			this.buttonRemoveOne.Click += new System.EventHandler(this.buttonRemoveOne_Click);
			// 
			// buttonRemoveAll
			// 
			this.buttonRemoveAll.Location = new System.Drawing.Point(356, 302);
			this.buttonRemoveAll.Name = "buttonRemoveAll";
			this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
			this.buttonRemoveAll.TabIndex = 5;
			this.buttonRemoveAll.Text = "<<";
			this.buttonRemoveAll.UseVisualStyleBackColor = true;
			this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRemoveAll);
			this.Controls.Add(this.buttonRemoveOne);
			this.Controls.Add(this.buttonPutAll);
			this.Controls.Add(this.buttonPutOne);
			this.Controls.Add(this.groupBoxSelected);
			this.Controls.Add(this.groupBoxListMH);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBoxListMH.ResumeLayout(false);
			this.groupBoxSelected.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxListMH;
		private System.Windows.Forms.ListBox listBoxMatHang;
		private System.Windows.Forms.GroupBox groupBoxSelected;
		private System.Windows.Forms.ListBox listBoxSelected;
		private System.Windows.Forms.Button buttonPutOne;
		private System.Windows.Forms.Button buttonPutAll;
		private System.Windows.Forms.Button buttonRemoveOne;
		private System.Windows.Forms.Button buttonRemoveAll;
	}
}

