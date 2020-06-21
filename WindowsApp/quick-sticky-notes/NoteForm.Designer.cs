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
			this.editPanel = new System.Windows.Forms.Panel();
			this.colorLabel = new System.Windows.Forms.Label();
			this.pinkBtn = new System.Windows.Forms.Button();
			this.blueBtn = new System.Windows.Forms.Button();
			this.greenBtn = new System.Windows.Forms.Button();
			this.yellowBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.modifiedTextBox = new System.Windows.Forms.TextBox();
			this.modifiedLabel = new System.Windows.Forms.Label();
			this.editTitleLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.notesListBtn = new System.Windows.Forms.Button();
			this.newNoteBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.secondTitleLabel = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
			this.resizeBtn = new System.Windows.Forms.Button();
			this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.editPanel.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.rmbContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// editPanel
			// 
			this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
			this.editPanel.Controls.Add(this.colorLabel);
			this.editPanel.Controls.Add(this.pinkBtn);
			this.editPanel.Controls.Add(this.blueBtn);
			this.editPanel.Controls.Add(this.greenBtn);
			this.editPanel.Controls.Add(this.yellowBtn);
			this.editPanel.Controls.Add(this.deleteBtn);
			this.editPanel.Controls.Add(this.modifiedTextBox);
			this.editPanel.Controls.Add(this.modifiedLabel);
			this.editPanel.Controls.Add(this.editTitleLabel);
			this.editPanel.Controls.Add(this.titleTextBox);
			this.editPanel.Location = new System.Drawing.Point(0, 30);
			this.editPanel.Margin = new System.Windows.Forms.Padding(0);
			this.editPanel.Name = "editPanel";
			this.editPanel.Size = new System.Drawing.Size(256, 226);
			this.editPanel.TabIndex = 1;
			this.editPanel.Visible = false;
			// 
			// colorLabel
			// 
			this.colorLabel.AutoSize = true;
			this.colorLabel.ForeColor = System.Drawing.Color.White;
			this.colorLabel.Location = new System.Drawing.Point(9, 47);
			this.colorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
			this.colorLabel.Name = "colorLabel";
			this.colorLabel.Size = new System.Drawing.Size(43, 17);
			this.colorLabel.TabIndex = 11;
			this.colorLabel.Text = "Color:";
			// 
			// pinkBtn
			// 
			this.pinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
			this.pinkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.pinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pinkBtn.Location = new System.Drawing.Point(163, 43);
			this.pinkBtn.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.pinkBtn.Name = "pinkBtn";
			this.pinkBtn.Size = new System.Drawing.Size(25, 25);
			this.pinkBtn.TabIndex = 10;
			this.pinkBtn.Text = "P";
			this.pinkBtn.UseVisualStyleBackColor = false;
			this.pinkBtn.Click += new System.EventHandler(this.pinkBtn_Click);
			// 
			// blueBtn
			// 
			this.blueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
			this.blueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.blueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.blueBtn.Location = new System.Drawing.Point(129, 43);
			this.blueBtn.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.blueBtn.Name = "blueBtn";
			this.blueBtn.Size = new System.Drawing.Size(25, 25);
			this.blueBtn.TabIndex = 9;
			this.blueBtn.Text = "B";
			this.blueBtn.UseVisualStyleBackColor = false;
			this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
			// 
			// greenBtn
			// 
			this.greenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
			this.greenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.greenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.greenBtn.Location = new System.Drawing.Point(95, 43);
			this.greenBtn.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.greenBtn.Name = "greenBtn";
			this.greenBtn.Size = new System.Drawing.Size(25, 25);
			this.greenBtn.TabIndex = 8;
			this.greenBtn.Text = "G";
			this.greenBtn.UseVisualStyleBackColor = false;
			this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
			// 
			// yellowBtn
			// 
			this.yellowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.yellowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.yellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yellowBtn.Location = new System.Drawing.Point(61, 43);
			this.yellowBtn.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.yellowBtn.Name = "yellowBtn";
			this.yellowBtn.Size = new System.Drawing.Size(25, 25);
			this.yellowBtn.TabIndex = 7;
			this.yellowBtn.Text = "Y";
			this.yellowBtn.UseVisualStyleBackColor = false;
			this.yellowBtn.Click += new System.EventHandler(this.yellowBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteBtn.BackColor = System.Drawing.Color.White;
			this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
			this.deleteBtn.Location = new System.Drawing.Point(9, 192);
			this.deleteBtn.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(238, 25);
			this.deleteBtn.TabIndex = 6;
			this.deleteBtn.Text = "Delete note";
			this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// modifiedTextBox
			// 
			this.modifiedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedTextBox.BackColor = System.Drawing.Color.White;
			this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modifiedTextBox.Location = new System.Drawing.Point(82, 158);
			this.modifiedTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 9);
			this.modifiedTextBox.Name = "modifiedTextBox";
			this.modifiedTextBox.ReadOnly = true;
			this.modifiedTextBox.Size = new System.Drawing.Size(165, 25);
			this.modifiedTextBox.TabIndex = 5;
			// 
			// modifiedLabel
			// 
			this.modifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.modifiedLabel.AutoSize = true;
			this.modifiedLabel.ForeColor = System.Drawing.Color.White;
			this.modifiedLabel.Location = new System.Drawing.Point(9, 160);
			this.modifiedLabel.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.modifiedLabel.Name = "modifiedLabel";
			this.modifiedLabel.Size = new System.Drawing.Size(64, 17);
			this.modifiedLabel.TabIndex = 4;
			this.modifiedLabel.Text = "Modified:";
			// 
			// editTitleLabel
			// 
			this.editTitleLabel.AutoSize = true;
			this.editTitleLabel.ForeColor = System.Drawing.Color.White;
			this.editTitleLabel.Location = new System.Drawing.Point(9, 11);
			this.editTitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.editTitleLabel.Name = "editTitleLabel";
			this.editTitleLabel.Size = new System.Drawing.Size(35, 17);
			this.editTitleLabel.TabIndex = 1;
			this.editTitleLabel.Text = "Title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextBox.BackColor = System.Drawing.Color.White;
			this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.titleTextBox.Location = new System.Drawing.Point(53, 9);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(194, 25);
			this.titleTextBox.TabIndex = 0;
			this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextBox_KeyDown);
			this.titleTextBox.Leave += new System.EventHandler(this.titleTextBox_Leave);
			// 
			// titlePanel
			// 
			this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.titlePanel.Controls.Add(this.notesListBtn);
			this.titlePanel.Controls.Add(this.newNoteBtn);
			this.titlePanel.Controls.Add(this.editBtn);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(256, 30);
			this.titlePanel.TabIndex = 6;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
			// 
			// notesListBtn
			// 
			this.notesListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.notesListBtn.FlatAppearance.BorderSize = 0;
			this.notesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.notesListBtn.Image = ((System.Drawing.Image)(resources.GetObject("notesListBtn.Image")));
			this.notesListBtn.Location = new System.Drawing.Point(196, 0);
			this.notesListBtn.Margin = new System.Windows.Forms.Padding(0);
			this.notesListBtn.Name = "notesListBtn";
			this.notesListBtn.Size = new System.Drawing.Size(30, 30);
			this.notesListBtn.TabIndex = 10;
			this.infoToolTip.SetToolTip(this.notesListBtn, "Show notes list (Ctrl+Shift+N)");
			this.notesListBtn.UseVisualStyleBackColor = true;
			this.notesListBtn.Click += new System.EventHandler(this.notesListBtn_Click);
			// 
			// newNoteBtn
			// 
			this.newNoteBtn.FlatAppearance.BorderSize = 0;
			this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newNoteBtn.Image = ((System.Drawing.Image)(resources.GetObject("newNoteBtn.Image")));
			this.newNoteBtn.Location = new System.Drawing.Point(0, 0);
			this.newNoteBtn.Margin = new System.Windows.Forms.Padding(0);
			this.newNoteBtn.Name = "newNoteBtn";
			this.newNoteBtn.Size = new System.Drawing.Size(30, 30);
			this.newNoteBtn.TabIndex = 9;
			this.infoToolTip.SetToolTip(this.newNoteBtn, "New note (Ctrl+N)");
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editBtn.FlatAppearance.BorderSize = 0;
			this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
			this.editBtn.Location = new System.Drawing.Point(166, 0);
			this.editBtn.Margin = new System.Windows.Forms.Padding(0);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(30, 30);
			this.editBtn.TabIndex = 7;
			this.infoToolTip.SetToolTip(this.editBtn, "Edit note (Ctrl+Shift+E)");
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(226, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(30, 30);
			this.closeBtn.TabIndex = 6;
			this.infoToolTip.SetToolTip(this.closeBtn, "Hide note (Ctrl+Q)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(30, 6);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(32, 17);
			this.titleLabel.TabIndex = 8;
			this.titleLabel.Text = "Title";
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
			// 
			// secondTitleLabel
			// 
			this.secondTitleLabel.AutoSize = true;
			this.secondTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
			this.secondTitleLabel.Location = new System.Drawing.Point(9, 15);
			this.secondTitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.secondTitleLabel.Name = "secondTitleLabel";
			this.secondTitleLabel.Size = new System.Drawing.Size(32, 17);
			this.secondTitleLabel.TabIndex = 9;
			this.secondTitleLabel.Text = "Title";
			this.secondTitleLabel.Visible = false;
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
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.Location = new System.Drawing.Point(11, 41);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(11);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBox1.Size = new System.Drawing.Size(234, 206);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
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
			this.rmbContext.Size = new System.Drawing.Size(248, 330);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// pasteAsPlainTextToolStripMenuItem
			// 
			this.pasteAsPlainTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteAsPlainTextToolStripMenuItem.Image")));
			this.pasteAsPlainTextToolStripMenuItem.Name = "pasteAsPlainTextToolStripMenuItem";
			this.pasteAsPlainTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
			this.pasteAsPlainTextToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.pasteAsPlainTextToolStripMenuItem.Text = "Paste as plain text";
			this.pasteAsPlainTextToolStripMenuItem.Click += new System.EventHandler(this.pasteAsPlainTextToolStripMenuItem_Click);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.selectAllToolStripMenuItem.Text = "Select all";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
			// 
			// toggleBulletsToolStripMenuItem
			// 
			this.toggleBulletsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toggleBulletsToolStripMenuItem.Image")));
			this.toggleBulletsToolStripMenuItem.Name = "toggleBulletsToolStripMenuItem";
			this.toggleBulletsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
			this.toggleBulletsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.toggleBulletsToolStripMenuItem.Text = "Toggle bullets";
			this.toggleBulletsToolStripMenuItem.Click += new System.EventHandler(this.toggleBulletsToolStripMenuItem_Click);
			// 
			// boldToolStripMenuItem
			// 
			this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
			this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.boldToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.boldToolStripMenuItem.Text = "Bold";
			this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
			// 
			// italicToolStripMenuItem
			// 
			this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
			this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.italicToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.italicToolStripMenuItem.Text = "Italic";
			this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
			// 
			// underlineToolStripMenuItem
			// 
			this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
			this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
			this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.underlineToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.underlineToolStripMenuItem.Text = "Underline";
			this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
			// 
			// strikethroughToolStripMenuItem
			// 
			this.strikethroughToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("strikethroughToolStripMenuItem.Image")));
			this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
			this.strikethroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.strikethroughToolStripMenuItem.Text = "Strikethrough";
			this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
			// 
			// capitalizeToolStripMenuItem
			// 
			this.capitalizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("capitalizeToolStripMenuItem.Image")));
			this.capitalizeToolStripMenuItem.Name = "capitalizeToolStripMenuItem";
			this.capitalizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
			this.capitalizeToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.capitalizeToolStripMenuItem.Text = "Capitalize";
			this.capitalizeToolStripMenuItem.Click += new System.EventHandler(this.capitalizeToolStripMenuItem_Click);
			// 
			// superscriptToolStripMenuItem
			// 
			this.superscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("superscriptToolStripMenuItem.Image")));
			this.superscriptToolStripMenuItem.Name = "superscriptToolStripMenuItem";
			this.superscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
			this.superscriptToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.superscriptToolStripMenuItem.Text = "Superscript";
			this.superscriptToolStripMenuItem.Click += new System.EventHandler(this.superscriptToolStripMenuItem_Click);
			// 
			// subscriptToolStripMenuItem
			// 
			this.subscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subscriptToolStripMenuItem.Image")));
			this.subscriptToolStripMenuItem.Name = "subscriptToolStripMenuItem";
			this.subscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.subscriptToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.subscriptToolStripMenuItem.Text = "Subscript";
			this.subscriptToolStripMenuItem.Click += new System.EventHandler(this.subscriptToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
			// 
			// textAlignToolStripMenuItem
			// 
			this.textAlignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlignToolStripMenuItem1,
            this.centerAlignToolStripMenuItem1,
            this.rightAlignToolStripMenuItem1});
			this.textAlignToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textAlignToolStripMenuItem.Image")));
			this.textAlignToolStripMenuItem.Name = "textAlignToolStripMenuItem";
			this.textAlignToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
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
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(256, 256);
			this.Controls.Add(this.editPanel);
			this.Controls.Add(this.secondTitleLabel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.resizeBtn);
			this.Controls.Add(this.richTextBox1);
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
			this.editPanel.ResumeLayout(false);
			this.editPanel.PerformLayout();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.rmbContext.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel editPanel;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Label modifiedLabel;
		private System.Windows.Forms.TextBox modifiedTextBox;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label editTitleLabel;
		private System.Windows.Forms.Label secondTitleLabel;
		private System.Windows.Forms.Button newNoteBtn;
		private System.Windows.Forms.Button deleteBtn;
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
		private System.Windows.Forms.Button yellowBtn;
		private System.Windows.Forms.Button greenBtn;
		private System.Windows.Forms.Button pinkBtn;
		private System.Windows.Forms.Button blueBtn;
		private System.Windows.Forms.Label colorLabel;
		private System.Windows.Forms.ToolStripMenuItem textAlignToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem centerAlignToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem1;
	}
}