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

namespace TreeViewGUI
{
	public partial class Form1 : Form
	{
		string path = @"E:\";

		public Form1()
		{
			InitializeComponent();

			//LoadTreeView();

			if (Directory.Exists(path))
			{
				TreeNode root = new TreeNode() { Text = path};
				treeViewShow.Nodes.Add(root);
				LoadExplorer(root);
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
					if (Directory.Exists(item.FullName))
					{
						TreeNode nodeRoot = new TreeNode() { Text = item.FullName };
						root.Nodes.Add(nodeRoot);
						LoadExplorer(nodeRoot);
					}
				}
			}
			catch (Exception)
			{
				return;
			}
		}
		
		void LoadTreeView()
		{
			treeViewShow.CheckBoxes = true;
			treeViewShow.NodeMouseClick += TreeViewShow_NodeMouseClick;

			TreeNode root = new TreeNode();
			root.Text = "Hai Zụ";
			root.ImageIndex = 0;

			TreeNode nodeRoot = new TreeNode() { Text = "Chửi"};
			root.Nodes.Add(nodeRoot);
			nodeRoot.ImageIndex = 1;
			nodeRoot.Checked = true;

			TreeNode root2 = new TreeNode();
			root2.Text = "Chần Dần";
			root2.ImageIndex = 2;

			TreeNode nodeRoot2 = new TreeNode() { Text = "Có súng đây nè" };
			root2.Nodes.Add(nodeRoot2);
			nodeRoot2.ImageIndex = 3;

			treeViewShow.Nodes.Add(root);
			treeViewShow.Nodes.Add(root2);
		}

		private void TreeViewShow_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			//MessageBox.Show(e.Node.Text);
			e.Node.Checked = !e.Node.Checked;
		}
	}
}
