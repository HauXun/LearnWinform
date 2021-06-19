
namespace MDINotepad
{
	partial class MDINotepad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDINotepad));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiGoTo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTimeDate = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTitleHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTitleVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.tsbPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCut = new System.Windows.Forms.ToolStripButton();
			this.tsbCopy = new System.Windows.Forms.ToolStripButton();
			this.tsbPast = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.stbHelp = new System.Windows.Forms.ToolStripButton();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.dlgFont = new System.Windows.Forms.FontDialog();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiView,
            this.tsmiHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripMenuItem1,
            this.tsmiPrint,
            this.toolStripMenuItem2,
            this.tsmiExit,
            this.toolStripMenuItem3});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "&FIle";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Image = global::MDINotepad.Properties.Resources.start_same_new_review;
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(126, 22);
			this.tsmiNew.Text = "&New";
			this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Image = global::MDINotepad.Properties.Resources.icon_folder_open;
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.Size = new System.Drawing.Size(126, 22);
			this.tsmiOpen.Text = "&Open";
			this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// tsmiSave
			// 
			this.tsmiSave.Image = global::MDINotepad.Properties.Resources.attribute_save;
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.Size = new System.Drawing.Size(126, 22);
			this.tsmiSave.Text = "&Save";
			this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
			// 
			// tsmiSaveAs
			// 
			this.tsmiSaveAs.Name = "tsmiSaveAs";
			this.tsmiSaveAs.Size = new System.Drawing.Size(126, 22);
			this.tsmiSaveAs.Text = "Save &As ...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
			// 
			// tsmiPrint
			// 
			this.tsmiPrint.Image = global::MDINotepad.Properties.Resources.attribute_print;
			this.tsmiPrint.Name = "tsmiPrint";
			this.tsmiPrint.Size = new System.Drawing.Size(126, 22);
			this.tsmiPrint.Text = "&Print";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(123, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(126, 22);
			this.tsmiExit.Text = "E&xit";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(123, 6);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripMenuItem5,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.toolStripMenuItem6,
            this.tsmiFind,
            this.tsmiFindNext,
            this.tsmiReplace,
            this.tsmiGoTo,
            this.toolStripMenuItem7,
            this.tsmiSelectAll,
            this.tsmiTimeDate});
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
			this.tsmiEdit.Text = "&Edit";
			// 
			// tsmiUndo
			// 
			this.tsmiUndo.Enabled = false;
			this.tsmiUndo.Name = "tsmiUndo";
			this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.tsmiUndo.Size = new System.Drawing.Size(180, 22);
			this.tsmiUndo.Text = "Undo";
			this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiCut
			// 
			this.tsmiCut.Name = "tsmiCut";
			this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.tsmiCut.Size = new System.Drawing.Size(180, 22);
			this.tsmiCut.Text = "Cut";
			// 
			// tsmiCopy
			// 
			this.tsmiCopy.Name = "tsmiCopy";
			this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
			this.tsmiCopy.Text = "Copy";
			// 
			// tsmiPaste
			// 
			this.tsmiPaste.Name = "tsmiPaste";
			this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.tsmiPaste.Size = new System.Drawing.Size(180, 22);
			this.tsmiPaste.Text = "Paste";
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
			this.tsmiDelete.Text = "Delete";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiFind
			// 
			this.tsmiFind.Name = "tsmiFind";
			this.tsmiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.tsmiFind.Size = new System.Drawing.Size(180, 22);
			this.tsmiFind.Text = "Find ...";
			// 
			// tsmiFindNext
			// 
			this.tsmiFindNext.Name = "tsmiFindNext";
			this.tsmiFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.tsmiFindNext.Size = new System.Drawing.Size(180, 22);
			this.tsmiFindNext.Text = "Find Next";
			// 
			// tsmiReplace
			// 
			this.tsmiReplace.Name = "tsmiReplace";
			this.tsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.tsmiReplace.Size = new System.Drawing.Size(180, 22);
			this.tsmiReplace.Text = "Replace";
			// 
			// tsmiGoTo
			// 
			this.tsmiGoTo.Name = "tsmiGoTo";
			this.tsmiGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.tsmiGoTo.Size = new System.Drawing.Size(180, 22);
			this.tsmiGoTo.Text = "Go To ...";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(177, 6);
			// 
			// tsmiSelectAll
			// 
			this.tsmiSelectAll.Name = "tsmiSelectAll";
			this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.tsmiSelectAll.Size = new System.Drawing.Size(180, 22);
			this.tsmiSelectAll.Text = "Select All";
			// 
			// tsmiTimeDate
			// 
			this.tsmiTimeDate.Name = "tsmiTimeDate";
			this.tsmiTimeDate.Size = new System.Drawing.Size(180, 22);
			this.tsmiTimeDate.Text = "Time/Date";
			// 
			// tsmiFormat
			// 
			this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWordWrap,
            this.tsmiFont});
			this.tsmiFormat.Name = "tsmiFormat";
			this.tsmiFormat.Size = new System.Drawing.Size(57, 20);
			this.tsmiFormat.Text = "&Format";
			// 
			// tsmiWordWrap
			// 
			this.tsmiWordWrap.Name = "tsmiWordWrap";
			this.tsmiWordWrap.Size = new System.Drawing.Size(134, 22);
			this.tsmiWordWrap.Text = "Word Wrap";
			// 
			// tsmiFont
			// 
			this.tsmiFont.Name = "tsmiFont";
			this.tsmiFont.Size = new System.Drawing.Size(134, 22);
			this.tsmiFont.Text = "Font";
			this.tsmiFont.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
			// 
			// tsmiView
			// 
			this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusBar,
            this.toolStripMenuItem4,
            this.tsmiArrangeIcons,
            this.tsmiCascade,
            this.tsmiTitleHorizontal,
            this.tsmiTitleVertical});
			this.tsmiView.Name = "tsmiView";
			this.tsmiView.Size = new System.Drawing.Size(44, 20);
			this.tsmiView.Text = "&View";
			// 
			// tsmiStatusBar
			// 
			this.tsmiStatusBar.Name = "tsmiStatusBar";
			this.tsmiStatusBar.Size = new System.Drawing.Size(154, 22);
			this.tsmiStatusBar.Text = "Status Bar";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(151, 6);
			// 
			// tsmiArrangeIcons
			// 
			this.tsmiArrangeIcons.Name = "tsmiArrangeIcons";
			this.tsmiArrangeIcons.Size = new System.Drawing.Size(154, 22);
			this.tsmiArrangeIcons.Text = "Arrange Icons";
			this.tsmiArrangeIcons.Click += new System.EventHandler(this.tsmiArrangeIcons_Click);
			// 
			// tsmiCascade
			// 
			this.tsmiCascade.Name = "tsmiCascade";
			this.tsmiCascade.Size = new System.Drawing.Size(154, 22);
			this.tsmiCascade.Text = "Cascade";
			this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
			// 
			// tsmiTitleHorizontal
			// 
			this.tsmiTitleHorizontal.Name = "tsmiTitleHorizontal";
			this.tsmiTitleHorizontal.Size = new System.Drawing.Size(154, 22);
			this.tsmiTitleHorizontal.Text = "Title Horizontal";
			this.tsmiTitleHorizontal.Click += new System.EventHandler(this.tsmiTitleHorizontal_Click);
			// 
			// tsmiTitleVertical
			// 
			this.tsmiTitleVertical.Name = "tsmiTitleVertical";
			this.tsmiTitleVertical.Size = new System.Drawing.Size(154, 22);
			this.tsmiTitleVertical.Text = "Title Vertical";
			this.tsmiTitleVertical.Click += new System.EventHandler(this.tsmiTitleVertical_Click);
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
			this.tsmiHelp.Text = "&Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel1,
            this.tsProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsStatusLabel1
			// 
			this.tsStatusLabel1.Name = "tsStatusLabel1";
			this.tsStatusLabel1.Size = new System.Drawing.Size(62, 17);
			this.tsStatusLabel1.Text = "Ln 1, Col 1";
			// 
			// tsProgressBar1
			// 
			this.tsProgressBar1.Name = "tsProgressBar1";
			this.tsProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbPrint,
            this.toolStripSeparator,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPast,
            this.toolStripSeparator1,
            this.stbHelp});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(23, 22);
			this.tsbNew.Text = "&New";
			this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
			// 
			// tsbOpen
			// 
			this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbOpen.Text = "&Open";
			// 
			// tsbSave
			// 
			this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(23, 22);
			this.tsbSave.Text = "&Save";
			// 
			// tsbPrint
			// 
			this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
			this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrint.Name = "tsbPrint";
			this.tsbPrint.Size = new System.Drawing.Size(23, 22);
			this.tsbPrint.Text = "&Print";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbCut
			// 
			this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
			this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCut.Name = "tsbCut";
			this.tsbCut.Size = new System.Drawing.Size(23, 22);
			this.tsbCut.Text = "C&ut";
			// 
			// tsbCopy
			// 
			this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
			this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCopy.Name = "tsbCopy";
			this.tsbCopy.Size = new System.Drawing.Size(23, 22);
			this.tsbCopy.Text = "&Copy";
			// 
			// tsbPast
			// 
			this.tsbPast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPast.Image = ((System.Drawing.Image)(resources.GetObject("tsbPast.Image")));
			this.tsbPast.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPast.Name = "tsbPast";
			this.tsbPast.Size = new System.Drawing.Size(23, 22);
			this.tsbPast.Text = "&Paste";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// stbHelp
			// 
			this.stbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stbHelp.Image = ((System.Drawing.Image)(resources.GetObject("stbHelp.Image")));
			this.stbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stbHelp.Name = "stbHelp";
			this.stbHelp.Size = new System.Drawing.Size(23, 22);
			this.stbHelp.Text = "He&lp";
			// 
			// dlgOpen
			// 
			this.dlgOpen.Filter = "Text File|*.txt|All Files|*.*";
			this.dlgOpen.Multiselect = true;
			// 
			// dlgSave
			// 
			this.dlgSave.Filter = "Text File|*.txt|All Files|*.*";
			// 
			// MDINotepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDINotepad";
			this.Text = "MDI Notepad";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.ToolStripButton tsbPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton tsbCut;
		private System.Windows.Forms.ToolStripButton tsbCopy;
		private System.Windows.Forms.ToolStripButton tsbPast;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton stbHelp;
		private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar tsProgressBar1;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private System.Windows.Forms.FontDialog dlgFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
		private System.Windows.Forms.ToolStripMenuItem tsmiView;
		private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem tsmiArrangeIcons;
		private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
		private System.Windows.Forms.ToolStripMenuItem tsmiTitleHorizontal;
		private System.Windows.Forms.ToolStripMenuItem tsmiTitleVertical;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
		private System.Windows.Forms.ToolStripMenuItem tsmiFont;
		private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem tsmiCut;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
		private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem tsmiFind;
		private System.Windows.Forms.ToolStripMenuItem tsmiFindNext;
		private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
		private System.Windows.Forms.ToolStripMenuItem tsmiGoTo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
		private System.Windows.Forms.ToolStripMenuItem tsmiTimeDate;
	}
}

