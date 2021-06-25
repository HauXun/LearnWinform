
namespace TreeViewGUI
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.treeViewShow = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// treeViewShow
			// 
			this.treeViewShow.ImageIndex = 0;
			this.treeViewShow.ImageList = this.imageList1;
			this.treeViewShow.Location = new System.Drawing.Point(12, 12);
			this.treeViewShow.Name = "treeViewShow";
			this.treeViewShow.SelectedImageIndex = 0;
			this.treeViewShow.Size = new System.Drawing.Size(626, 426);
			this.treeViewShow.TabIndex = 0;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "15yearsdefqon.png");
			this.imageList1.Images.SetKeyName(1, "SundayFunday.png");
			this.imageList1.Images.SetKeyName(2, "TheClosingCeremory.jpeg");
			this.imageList1.Images.SetKeyName(3, "PowerHour.png");
			this.imageList1.Images.SetKeyName(4, "TheCamping.png");
			this.imageList1.Images.SetKeyName(5, "TheGathering.png");
			this.imageList1.Images.SetKeyName(6, "WastedLand.PNG");
			this.imageList1.Images.SetKeyName(7, "TheEndshow.PNG");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.treeViewShow);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewShow;
		private System.Windows.Forms.ImageList imageList1;
	}
}

