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

namespace MDINotepad
{
	public partial class MDINotepad : Form
	{
		static byte index = 0;
		public MDINotepad()
		{
			InitializeComponent();
		}

		private void tsmiNew_Click(object sender, EventArgs e)
		{
			formNotepad form = new formNotepad();
			form.MdiParent = this;
			form.Text = "Untitled " + ++index;
			form.Show();
		}

		private void tsbNew_Click(object sender, EventArgs e)
		{
			tsmiNew_Click(sender, e); 
		}

		private void tsmiOpen_Click(object sender, EventArgs e)
		{
			// Khai báo form con
			formNotepad form = new formNotepad();

			if (dlgOpen.ShowDialog() == DialogResult.OK)
			{
				if (dlgOpen.FileName != null)
				{
					// Sử dụng đối tượng StreamReader để đọc File
					StreamReader stream = new StreamReader(dlgOpen.FileName, UnicodeEncoding.Unicode);

					// Gắn dữ liệu lên Form
					form.rtbNotepad.Text = stream.ReadToEnd();

					// Cập nhập lại title của form con
					form.Text = dlgOpen.SafeFileName;
					form.MdiParent = this;
					form.Show();

					// Giải phóng đối tượng stream
					stream.Dispose();
				}	
			}	
		}

		private void tsmiSave_Click(object sender, EventArgs e)
		{
			formNotepad form = (formNotepad)this.ActiveMdiChild;

			if (dlgSave.ShowDialog() == DialogResult.OK)
			{
				if (dlgSave.FileName != null)
				{
					form.rtbNotepad.SaveFile(dlgSave.FileName, RichTextBoxStreamType.UnicodePlainText);
					form.Text = dlgSave.FileName;
				}	
			}
		}

		private void tsmiArrangeIcons_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void tsmiCascade_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void tsmiTitleHorizontal_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tsmiTitleVertical_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dlgFont.ShowDialog() == DialogResult.OK)
			{
				formNotepad form = (formNotepad)this.ActiveMdiChild;
				if (form.rtbNotepad.SelectionLength == 0)
				{
					form.rtbNotepad.Font = dlgFont.Font;
				}
				else
				{
					form.rtbNotepad.SelectionFont = dlgFont.Font;
				}
			}	
		}

		private void tsmiUndo_Click(object sender, EventArgs e)
		{
			formNotepad form = (formNotepad)this.ActiveMdiChild;
			form.rtbNotepad.Undo();
		}
	}
}
