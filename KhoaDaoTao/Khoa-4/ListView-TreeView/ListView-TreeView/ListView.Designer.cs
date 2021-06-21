
namespace ListView_TreeView
{
	partial class ListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
			this.listView1 = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnLarge = new System.Windows.Forms.Button();
			this.btnSmall = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.btnDetail = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.LabelEdit = true;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(655, 426);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon_folder_open.png");
			this.imageList1.Images.SetKeyName(1, "tag_16_new.png");
			this.imageList1.Images.SetKeyName(2, "DeletedIcon.png");
			// 
			// btnLarge
			// 
			this.btnLarge.Location = new System.Drawing.Point(695, 12);
			this.btnLarge.Name = "btnLarge";
			this.btnLarge.Size = new System.Drawing.Size(75, 23);
			this.btnLarge.TabIndex = 1;
			this.btnLarge.Text = "Large";
			this.btnLarge.UseVisualStyleBackColor = true;
			this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
			// 
			// btnSmall
			// 
			this.btnSmall.Location = new System.Drawing.Point(695, 49);
			this.btnSmall.Name = "btnSmall";
			this.btnSmall.Size = new System.Drawing.Size(75, 23);
			this.btnSmall.TabIndex = 2;
			this.btnSmall.Text = "Small";
			this.btnSmall.UseVisualStyleBackColor = true;
			this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(695, 86);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(75, 23);
			this.btnList.TabIndex = 3;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnDetail
			// 
			this.btnDetail.Location = new System.Drawing.Point(695, 123);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(75, 23);
			this.btnDetail.TabIndex = 4;
			this.btnDetail.Text = "Detail";
			this.btnDetail.UseVisualStyleBackColor = true;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDetail);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.btnSmall);
			this.Controls.Add(this.btnLarge);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnLarge;
		private System.Windows.Forms.Button btnSmall;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnDetail;
		private System.Windows.Forms.ImageList imageList1;
	}
}

