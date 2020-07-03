namespace quick_sticky_notes
{
	partial class NoteForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.headerContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.createdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeBtn = new System.Windows.Forms.Button();
			this.notesListBtn = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.newNoteBtn = new System.Windows.Forms.Button();
			this.secondTitleLabel = new System.Windows.Forms.Label();
			this.rmbContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteAsPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toggleBulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.capitalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.superscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.subscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.textAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leftAlignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.centerAlignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.rightAlignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.resizeBtn = new System.Windows.Forms.Button();
			this.richTextBox1 = new quick_sticky_notes.CustomRichTextBox();
			this.customScrollbar1 = new quick_sticky_notes.CustomScrollbar();
			this.titlePanel.SuspendLayout();
			this.headerContext.SuspendLayout();
			this.rmbContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleTextBox
			// 
			this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.titleTextBox.ForeColor = System.Drawing.Color.White;
			this.titleTextBox.Location = new System.Drawing.Point(38, 7);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(154, 18);
			this.titleTextBox.TabIndex = 0;
			this.titleTextBox.Text = "Title";
			this.titleTextBox.Visible = false;
			this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextBox_KeyDown);
			this.titleTextBox.Leave += new System.EventHandler(this.titleTextBox_Leave);
			// 
			// titlePanel
			// 
			this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.titlePanel.ContextMenuStrip = this.headerContext;
			this.titlePanel.Controls.Add(this.titleTextBox);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.notesListBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.newNoteBtn);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(256, 32);
			this.titlePanel.TabIndex = 6;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
			// 
			// headerContext
			// 
			this.headerContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.changeColorToolStripMenuItem,
            this.toolStripSeparator3,
            this.createdToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem});
			this.headerContext.Name = "headerContext";
			this.headerContext.Size = new System.Drawing.Size(191, 104);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renameToolStripMenuItem.Image")));
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// changeColorToolStripMenuItem
			// 
			this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.whiteToolStripMenuItem});
			this.changeColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeColorToolStripMenuItem.Image")));
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
			this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.changeColorToolStripMenuItem.Text = "Change color";
			// 
			// yellowToolStripMenuItem
			// 
			this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.yellowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
			this.yellowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.yellowToolStripMenuItem.Text = "Yellow";
			this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowBtn_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
			this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenBtn_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
			this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(97)))), ((int)(((byte)(127)))));
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueBtn_Click);
			// 
			// pinkToolStripMenuItem
			// 
			this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
			this.pinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
			this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
			this.pinkToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.pinkToolStripMenuItem.Text = "Pink";
			this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkBtn_Click);
			// 
			// purpleToolStripMenuItem
			// 
			this.purpleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
			this.purpleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
			this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
			this.purpleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.purpleToolStripMenuItem.Text = "Purple";
			this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
			// 
			// whiteToolStripMenuItem
			// 
			this.whiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.whiteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
			this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
			this.whiteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.whiteToolStripMenuItem.Text = "White";
			this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
			// 
			// createdToolStripMenuItem
			// 
			this.createdToolStripMenuItem.Enabled = false;
			this.createdToolStripMenuItem.Name = "createdToolStripMenuItem";
			this.createdToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.createdToolStripMenuItem.Text = "Created";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.deleteToolStripMenuItem.Text = "Move to trash";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(224, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 6;
			this.infoToolTip.SetToolTip(this.closeBtn, "Hide note (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// notesListBtn
			// 
			this.notesListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.notesListBtn.FlatAppearance.BorderSize = 0;
			this.notesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.notesListBtn.Image = ((System.Drawing.Image)(resources.GetObject("notesListBtn.Image")));
			this.notesListBtn.Location = new System.Drawing.Point(192, 0);
			this.notesListBtn.Margin = new System.Windows.Forms.Padding(0);
			this.notesListBtn.Name = "notesListBtn";
			this.notesListBtn.Size = new System.Drawing.Size(32, 32);
			this.notesListBtn.TabIndex = 10;
			this.infoToolTip.SetToolTip(this.notesListBtn, "Show notes list (Ctrl+Shift+N)");
			this.notesListBtn.UseVisualStyleBackColor = true;
			this.notesListBtn.Click += new System.EventHandler(this.notesListBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(35, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(32, 17);
			this.titleLabel.TabIndex = 11;
			this.titleLabel.Text = "Title";
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
			// 
			// newNoteBtn
			// 
			this.newNoteBtn.FlatAppearance.BorderSize = 0;
			this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newNoteBtn.Image = ((System.Drawing.Image)(resources.GetObject("newNoteBtn.Image")));
			this.newNoteBtn.Location = new System.Drawing.Point(1, 0);
			this.newNoteBtn.Margin = new System.Windows.Forms.Padding(0);
			this.newNoteBtn.Name = "newNoteBtn";
			this.newNoteBtn.Size = new System.Drawing.Size(32, 32);
			this.newNoteBtn.TabIndex = 9;
			this.infoToolTip.SetToolTip(this.newNoteBtn, "New note (Ctrl+N)");
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// secondTitleLabel
			// 
			this.secondTitleLabel.AutoSize = true;
			this.secondTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
			this.secondTitleLabel.Location = new System.Drawing.Point(13, 21);
			this.secondTitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.secondTitleLabel.Name = "secondTitleLabel";
			this.secondTitleLabel.Size = new System.Drawing.Size(36, 17);
			this.secondTitleLabel.TabIndex = 9;
			this.secondTitleLabel.Text = "Title";
			this.secondTitleLabel.Visible = false;
			// 
			// rmbContext
			// 
			this.rmbContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.pasteAsPlainTextToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.toggleBulletsToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikethroughToolStripMenuItem,
            this.toolStripSeparator4,
            this.capitalizeToolStripMenuItem,
            this.superscriptToolStripMenuItem,
            this.subscriptToolStripMenuItem,
            this.toolStripSeparator2,
            this.textAlignToolStripMenuItem});
			this.rmbContext.Name = "rmbContext";
			this.rmbContext.Size = new System.Drawing.Size(249, 330);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// pasteAsPlainTextToolStripMenuItem
			// 
			this.pasteAsPlainTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteAsPlainTextToolStripMenuItem.Image")));
			this.pasteAsPlainTextToolStripMenuItem.Name = "pasteAsPlainTextToolStripMenuItem";
			this.pasteAsPlainTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
			this.pasteAsPlainTextToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.pasteAsPlainTextToolStripMenuItem.Text = "Paste as plain text";
			this.pasteAsPlainTextToolStripMenuItem.Click += new System.EventHandler(this.pasteAsPlainTextToolStripMenuItem_Click);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.selectAllToolStripMenuItem.Text = "Select all";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
			// 
			// toggleBulletsToolStripMenuItem
			// 
			this.toggleBulletsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toggleBulletsToolStripMenuItem.Image")));
			this.toggleBulletsToolStripMenuItem.Name = "toggleBulletsToolStripMenuItem";
			this.toggleBulletsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
			this.toggleBulletsToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.toggleBulletsToolStripMenuItem.Text = "Toggle bullets";
			this.toggleBulletsToolStripMenuItem.Click += new System.EventHandler(this.toggleBulletsToolStripMenuItem_Click);
			// 
			// boldToolStripMenuItem
			// 
			this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
			this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.boldToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.boldToolStripMenuItem.Text = "Bold";
			this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
			// 
			// italicToolStripMenuItem
			// 
			this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
			this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.italicToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.italicToolStripMenuItem.Text = "Italic";
			this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
			// 
			// underlineToolStripMenuItem
			// 
			this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
			this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
			this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.underlineToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.underlineToolStripMenuItem.Text = "Underline";
			this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
			// 
			// strikethroughToolStripMenuItem
			// 
			this.strikethroughToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("strikethroughToolStripMenuItem.Image")));
			this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
			this.strikethroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.strikethroughToolStripMenuItem.Text = "Strikethrough";
			this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(245, 6);
			// 
			// capitalizeToolStripMenuItem
			// 
			this.capitalizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("capitalizeToolStripMenuItem.Image")));
			this.capitalizeToolStripMenuItem.Name = "capitalizeToolStripMenuItem";
			this.capitalizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
			this.capitalizeToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.capitalizeToolStripMenuItem.Text = "Capitalize";
			this.capitalizeToolStripMenuItem.Click += new System.EventHandler(this.capitalizeToolStripMenuItem_Click);
			// 
			// superscriptToolStripMenuItem
			// 
			this.superscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("superscriptToolStripMenuItem.Image")));
			this.superscriptToolStripMenuItem.Name = "superscriptToolStripMenuItem";
			this.superscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
			this.superscriptToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.superscriptToolStripMenuItem.Text = "Superscript";
			this.superscriptToolStripMenuItem.Click += new System.EventHandler(this.superscriptToolStripMenuItem_Click);
			// 
			// subscriptToolStripMenuItem
			// 
			this.subscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subscriptToolStripMenuItem.Image")));
			this.subscriptToolStripMenuItem.Name = "subscriptToolStripMenuItem";
			this.subscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.subscriptToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.subscriptToolStripMenuItem.Text = "Subscript";
			this.subscriptToolStripMenuItem.Click += new System.EventHandler(this.subscriptToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
			// 
			// textAlignToolStripMenuItem
			// 
			this.textAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlignToolStripMenuItem1,
            this.centerAlignToolStripMenuItem1,
            this.rightAlignToolStripMenuItem1});
			this.textAlignToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textAlignToolStripMenuItem.Image")));
			this.textAlignToolStripMenuItem.Name = "textAlignToolStripMenuItem";
			this.textAlignToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
			this.textAlignToolStripMenuItem.Text = "Text align";
			// 
			// leftAlignToolStripMenuItem1
			// 
			this.leftAlignToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignToolStripMenuItem1.Image")));
			this.leftAlignToolStripMenuItem1.Name = "leftAlignToolStripMenuItem1";
			this.leftAlignToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.leftAlignToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.leftAlignToolStripMenuItem1.Text = "Left align";
			this.leftAlignToolStripMenuItem1.Click += new System.EventHandler(this.leftAlignToolStripMenuItem_Click);
			// 
			// centerAlignToolStripMenuItem1
			// 
			this.centerAlignToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignToolStripMenuItem1.Image")));
			this.centerAlignToolStripMenuItem1.Name = "centerAlignToolStripMenuItem1";
			this.centerAlignToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.centerAlignToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.centerAlignToolStripMenuItem1.Text = "Center align";
			this.centerAlignToolStripMenuItem1.Click += new System.EventHandler(this.centerAlignToolStripMenuItem_Click);
			// 
			// rightAlignToolStripMenuItem1
			// 
			this.rightAlignToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignToolStripMenuItem1.Image")));
			this.rightAlignToolStripMenuItem1.Name = "rightAlignToolStripMenuItem1";
			this.rightAlignToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.rightAlignToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.rightAlignToolStripMenuItem1.Text = "Right align";
			this.rightAlignToolStripMenuItem1.Click += new System.EventHandler(this.rightAlignToolStripMenuItem_Click);
			// 
			// resizeBtn
			// 
			this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizeBtn.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizeBtn.FlatAppearance.BorderSize = 0;
			this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resizeBtn.Image")));
			this.resizeBtn.Location = new System.Drawing.Point(239, 239);
			this.resizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.resizeBtn.Name = "resizeBtn";
			this.resizeBtn.Size = new System.Drawing.Size(17, 17);
			this.resizeBtn.TabIndex = 15;
			this.resizeBtn.TabStop = false;
			this.infoToolTip.SetToolTip(this.resizeBtn, "Drag here to resize");
			this.resizeBtn.UseVisualStyleBackColor = false;
			this.resizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseDown);
			this.resizeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseUp);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.ContextMenuStrip = this.rmbContext;
			this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.richTextBox1.Location = new System.Drawing.Point(15, 49);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 17, 0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox1.Size = new System.Drawing.Size(241, 190);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
			this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
			this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
			// 
			// customScrollbar1
			// 
			this.customScrollbar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.customScrollbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.customScrollbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.customScrollbar1.DownArrowImage = global::quick_sticky_notes.Properties.Resources.sb_downarrow_y;
			this.customScrollbar1.LargeChange = 10;
			this.customScrollbar1.Location = new System.Drawing.Point(239, 32);
			this.customScrollbar1.Margin = new System.Windows.Forms.Padding(0);
			this.customScrollbar1.Maximum = 100;
			this.customScrollbar1.Minimum = 0;
			this.customScrollbar1.MinimumSize = new System.Drawing.Size(13, 82);
			this.customScrollbar1.Name = "customScrollbar1";
			this.customScrollbar1.Size = new System.Drawing.Size(17, 207);
			this.customScrollbar1.SmallChange = 1;
			this.customScrollbar1.TabIndex = 16;
			this.customScrollbar1.ThumbMiddleImage = global::quick_sticky_notes.Properties.Resources.sb_thumbmiddle_y;
			this.customScrollbar1.UpArrowImage = global::quick_sticky_notes.Properties.Resources.sb_uparrow_y;
			this.customScrollbar1.Value = 0;
			this.customScrollbar1.Visible = false;
			this.customScrollbar1.Scroll += new System.EventHandler(this.customScrollbar1_Scroll);
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(256, 256);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.secondTitleLabel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.resizeBtn);
			this.Controls.Add(this.customScrollbar1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "NoteForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "NoteForm";
			this.Activated += new System.EventHandler(this.NoteForm_Activated);
			this.Deactivate += new System.EventHandler(this.NoteForm_Deactivate);
			this.Load += new System.EventHandler(this.NoteForm_Load);
			this.TextChanged += new System.EventHandler(this.NoteForm_TextChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteForm_KeyDown);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.headerContext.ResumeLayout(false);
			this.rmbContext.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button closeBtn;
		private CustomRichTextBox richTextBox1;
		private System.Windows.Forms.Label secondTitleLabel;
		private System.Windows.Forms.Button newNoteBtn;
		private System.Windows.Forms.Button resizeBtn;
		private System.Windows.Forms.ToolTip infoToolTip;
		private System.Windows.Forms.ContextMenuStrip rmbContext;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleBulletsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem capitalizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem superscriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem subscriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem pasteAsPlainTextToolStripMenuItem;
		private System.Windows.Forms.Button notesListBtn;
		private System.Windows.Forms.ToolStripMenuItem textAlignToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem centerAlignToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip headerContext;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem createdToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
		private CustomScrollbar customScrollbar1;
	}
}