
namespace ListView_TreeView
{
	partial class TreeView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
			this.tvShow = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lvShow = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// tvShow
			// 
			this.tvShow.Location = new System.Drawing.Point(12, 12);
			this.tvShow.Name = "tvShow";
			this.tvShow.Size = new System.Drawing.Size(260, 415);
			this.tvShow.TabIndex = 0;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Book.ico");
			this.imageList1.Images.SetKeyName(1, "Communication.ico");
			this.imageList1.Images.SetKeyName(2, "Console.ico");
			this.imageList1.Images.SetKeyName(3, "ConsoleToo.ico");
			this.imageList1.Images.SetKeyName(4, "Crazy.ico");
			this.imageList1.Images.SetKeyName(5, "Danger.ico");
			this.imageList1.Images.SetKeyName(6, "DLL.ico");
			this.imageList1.Images.SetKeyName(7, "Documentation.ico");
			this.imageList1.Images.SetKeyName(8, "Edit.ico");
			this.imageList1.Images.SetKeyName(9, "Editor.ico");
			this.imageList1.Images.SetKeyName(10, "Empty.ico");
			this.imageList1.Images.SetKeyName(11, "File Management.ico");
			this.imageList1.Images.SetKeyName(12, "Folder.ico");
			this.imageList1.Images.SetKeyName(13, "Food.ico");
			this.imageList1.Images.SetKeyName(14, "Games.ico");
			this.imageList1.Images.SetKeyName(15, "Goofy.ico");
			this.imageList1.Images.SetKeyName(16, "mainicon.ico");
			this.imageList1.Images.SetKeyName(17, "Movie.ico");
			this.imageList1.Images.SetKeyName(18, "Multimedia.ico");
			this.imageList1.Images.SetKeyName(19, "Paint.ico");
			this.imageList1.Images.SetKeyName(20, "Pizza.ico");
			this.imageList1.Images.SetKeyName(21, "Rescue.ico");
			this.imageList1.Images.SetKeyName(22, "Smile.ico");
			this.imageList1.Images.SetKeyName(23, "Software.ico");
			this.imageList1.Images.SetKeyName(24, "StaticLib.ico");
			this.imageList1.Images.SetKeyName(25, "Ufo.ico");
			this.imageList1.Images.SetKeyName(26, "Window.ico");
			this.imageList1.Images.SetKeyName(27, "Windows.ico");
			this.imageList1.Images.SetKeyName(28, "favicon.ico");
			// 
			// lvShow
			// 
			this.lvShow.HideSelection = false;
			this.lvShow.Location = new System.Drawing.Point(278, 12);
			this.lvShow.Name = "lvShow";
			this.lvShow.Size = new System.Drawing.Size(510, 415);
			this.lvShow.TabIndex = 1;
			this.lvShow.UseCompatibleStateImageBehavior = false;
			this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
			// 
			// TreeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lvShow);
			this.Controls.Add(this.tvShow);
			this.Name = "TreeView";
			this.Text = "TreeView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tvShow;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView lvShow;
	}
}