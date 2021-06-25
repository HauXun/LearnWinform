using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ListView_TreeView
{
	public partial class TreeView : Form
	{
		StatusStrip status = new StatusStrip();
		ToolStripStatusLabel label = new ToolStripStatusLabel();
		string path = @"F:\";
		public TreeView()
		{
			InitializeComponent();
			Load();

			//LoadTreeView();
		}

		void Load()
		{

			// Gắn imageList vào listView và treeView
			lvShow.LargeImageList = imageList1;
			tvShow.ImageList = imageList1;

			imageList1.ImageSize = new Size(20, 20);

			if (Directory.Exists(path))
			{
				TreeNode root = new TreeNode() { Text = new DirectoryInfo(path).FullName,
					Tag = new DirectoryInfo(path).FullName };
				tvShow.Nodes.Add(root);

				LoadExplorer(root);
			}
			label.Text = "";
			status.Items.Add(label);
			this.Controls.Add(status);

			// Gắn event vào treeView để khi nhấn vào 1 node. Sẽ hiển thị thông tin của treeView bên listView
			tvShow.AfterSelect += TvShow_AfterSelect;
		}

		private void TvShow_AfterSelect(object sender, TreeViewEventArgs e)
		{
			System.Windows.Forms.TreeView tree = sender as System.Windows.Forms.TreeView;
			TreeNode node = tree.SelectedNode;

			if (node == null)
				return;

			lvShow.Items.Clear();

			// Lấy ra danh sách các folder
			DirectoryInfo[] folder = null;
			try
			{
				folder = new DirectoryInfo(node.Tag.ToString()).GetDirectories();
			}
			catch { }

			if (folder != null)
			{
				foreach (var item in folder)
				{
					if (item != null)
					{
						hImgSmall = Win32.SHGetFileInfo(item.FullName, 0, ref shinfo,
								(uint)Marshal.SizeOf(shinfo),
								Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);
						Icon icon = Icon.FromHandle(shinfo.iICon);
						try
						{
							imageList1.Images.Add(icon);
						}
						catch { }
						lvShow.Items.Add(new ListViewItem(item.Name) { ImageIndex = imageList1.Images.Count - 1 });
					}
				}
			}

			// Lấy ra danh sách các file
			FileInfo[] files = null;
			try
			{
				files = new DirectoryInfo(node.Tag.ToString()).GetFiles();
			}
			catch { }

			if (files != null)
			{
				foreach (var item in files)
				{
					if (item != null)
					{
						Icon icon = Icon.ExtractAssociatedIcon(item.FullName);
						try
						{
							imageList1.Images.Add(icon);
						}
						catch { }
						lvShow.Items.Add(new ListViewItem(item.Name) { ImageIndex = imageList1.Images.Count - 1 });
					}
				}
			}
		}

		void LoadExplorer(TreeNode root)
		{
			if (root == null)
				return;

			try
			{
				var folderList = new DirectoryInfo(root.Text).GetDirectories();

				if (folderList.Count() == 0)
					return;

				foreach (DirectoryInfo item in folderList)
				{
					hImgSmall = Win32.SHGetFileInfo(item.FullName, 0, ref shinfo,
						(uint)Marshal.SizeOf(shinfo),
						Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

					Icon icon = Icon.FromHandle(shinfo.iICon);
					try
					{
						imageList1.Images.Add(icon);
					}
					catch { }

					if (Directory.Exists(item.FullName))
					{
						TreeNode node = new TreeNode()
						{
							Text = item.FullName,
							Tag = item.FullName,
							ImageIndex = imageList1.Images.Count - 1
						};
						root.Nodes.Add(node);
						LoadExplorer(node);
					}
				}
			}
			catch { }
		}

		SHFILEINFO shinfo = new SHFILEINFO();
		IntPtr hImgSmall;
		[StructLayout(LayoutKind.Sequential)]
		public struct SHFILEINFO
		{
			public IntPtr hIcon;
			public IntPtr iICon;
			public uint dwAttributes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		};
		class Win32
		{
			public const uint SHGFI_ICON = 0x100;
			public const uint SHGFI_LARGEICON = 0x0;    // Large icon
			public const uint SHGFI_SMALLICON = 0x1;    // Small icon

			[DllImport("shell32.dll")]
			public static extern IntPtr SHGetFileInfo(string pszpath,
				uint dwFileAttributes,
				ref SHFILEINFO psfi,
				uint cbSizeFileInfo,
				uint uFlags);
		}

		private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tvShow.SelectedNode == null || lvShow.SelectedItems.Count <= 0)
				return;

			string path = tvShow.SelectedNode.Tag + "\\" + lvShow.SelectedItems[0].Text;

			try
			{
				FileInfo file = new FileInfo(path);

				label.Text = $"{file.FullName} {file.Length / 1024}Mb {file.CreationTime.ToString()}";
			}
			catch (Exception)
			{
				DirectoryInfo dir = new DirectoryInfo(path);
				label.Text = $"{dir.FullName} {dir.CreationTime.ToString()}";
			}
		}
	}
}
