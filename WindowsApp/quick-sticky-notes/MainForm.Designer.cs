namespace quick_sticky_notes
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notesListBox = new System.Windows.Forms.ListBox();
			this.notesListItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.changeColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesListEmptyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.profileBtn = new System.Windows.Forms.Button();
			this.newNoteBtn = new System.Windows.Forms.Button();
			this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.aboutBtn = new System.Windows.Forms.Button();
			this.settingsBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.allNotesBtn = new System.Windows.Forms.Button();
			this.pinnedNotesBtn = new System.Windows.Forms.Button();
			this.trashBtn = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.sidePanel = new System.Windows.Forms.Panel();
			this.sidebarToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trashListItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notesListItemContext.SuspendLayout();
			this.notesListEmptyContext.SuspendLayout();
			this.trayContext.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.sidePanel.SuspendLayout();
			this.trashListItemContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// notesListBox
			// 
			this.notesListBox.BackColor = System.Drawing.Color.White;
			this.notesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.notesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.notesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesListBox.FormattingEnabled = true;
			this.notesListBox.IntegralHeight = false;
			this.notesListBox.ItemHeight = 64;
			this.notesListBox.Location = new System.Drawing.Point(32, 64);
			this.notesListBox.Margin = new System.Windows.Forms.Padding(0);
			this.notesListBox.Name = "notesListBox";
			this.notesListBox.Size = new System.Drawing.Size(247, 325);
			this.notesListBox.TabIndex = 2;
			this.notesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.notesListBox_DrawItem);
			this.notesListBox.DoubleClick += new System.EventHandler(this.notesListBox_DoubleClick_1);
			this.notesListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notesListBox_MouseUp);
			// 
			// notesListItemContext
			// 
			this.notesListItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator3,
            this.changeColorMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
			this.notesListItemContext.Name = "notesListContext";
			this.notesListItemContext.Size = new System.Drawing.Size(148, 82);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
			// 
			// changeColorMenuItem
			// 
			this.changeColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.whiteToolStripMenuItem});
			this.changeColorMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeColorMenuItem.Image")));
			this.changeColorMenuItem.Name = "changeColorMenuItem";
			this.changeColorMenuItem.Size = new System.Drawing.Size(147, 22);
			this.changeColorMenuItem.Text = "Change color";
			// 
			// yellowToolStripMenuItem
			// 
			this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.yellowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
			this.yellowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.yellowToolStripMenuItem.Text = "Yellow";
			this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
			this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
			this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(97)))), ((int)(((byte)(127)))));
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// pinkToolStripMenuItem
			// 
			this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
			this.pinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
			this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
			this.pinkToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.pinkToolStripMenuItem.Text = "Pink";
			this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
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
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.deleteToolStripMenuItem.Text = "Move to trash";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// notesListEmptyContext
			// 
			this.notesListEmptyContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem});
			this.notesListEmptyContext.Name = "notesListContext";
			this.notesListEmptyContext.Size = new System.Drawing.Size(124, 26);
			// 
			// addNoteToolStripMenuItem
			// 
			this.addNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNoteToolStripMenuItem.Image")));
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.addNoteToolStripMenuItem.Text = "Add note";
			this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayContext;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "Tinote";
			this.trayIcon.Visible = true;
			this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
			// 
			// trayContext
			// 
			this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesListToolStripMenuItem,
            this.newNoteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.trayContext.Name = "notesListContext";
			this.trayContext.Size = new System.Drawing.Size(126, 76);
			// 
			// notesListToolStripMenuItem
			// 
			this.notesListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notesListToolStripMenuItem.Image")));
			this.notesListToolStripMenuItem.Name = "notesListToolStripMenuItem";
			this.notesListToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.notesListToolStripMenuItem.Text = "Notes list";
			this.notesListToolStripMenuItem.Click += new System.EventHandler(this.notesListToolStripMenuItem_Click);
			// 
			// newNoteToolStripMenuItem
			// 
			this.newNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newNoteToolStripMenuItem.Image")));
			this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
			this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.newNoteToolStripMenuItem.Text = "New note";
			this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.searchTextBox.Location = new System.Drawing.Point(32, 7);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(182, 18);
			this.searchTextBox.TabIndex = 4;
			this.searchTextBox.Text = "Search your notes...";
			this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
			this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
			this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
			// 
			// searchPanel
			// 
			this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
			this.searchPanel.Controls.Add(this.searchTextBox);
			this.searchPanel.Controls.Add(this.profileBtn);
			this.searchPanel.Controls.Add(this.newNoteBtn);
			this.searchPanel.Location = new System.Drawing.Point(32, 32);
			this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(247, 32);
			this.searchPanel.TabIndex = 5;
			// 
			// profileBtn
			// 
			this.profileBtn.FlatAppearance.BorderSize = 0;
			this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
			this.profileBtn.Location = new System.Drawing.Point(0, 0);
			this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
			this.profileBtn.Name = "profileBtn";
			this.profileBtn.Size = new System.Drawing.Size(32, 32);
			this.profileBtn.TabIndex = 1;
			this.infoToolTip.SetToolTip(this.profileBtn, "Profile (Ctrl+Shift+P)");
			this.profileBtn.UseVisualStyleBackColor = true;
			this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
			// 
			// newNoteBtn
			// 
			this.newNoteBtn.FlatAppearance.BorderSize = 0;
			this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newNoteBtn.Image = ((System.Drawing.Image)(resources.GetObject("newNoteBtn.Image")));
			this.newNoteBtn.Location = new System.Drawing.Point(214, 0);
			this.newNoteBtn.Margin = new System.Windows.Forms.Padding(0);
			this.newNoteBtn.Name = "newNoteBtn";
			this.newNoteBtn.Size = new System.Drawing.Size(32, 32);
			this.newNoteBtn.TabIndex = 0;
			this.infoToolTip.SetToolTip(this.newNoteBtn, "New note (Ctrl+N)");
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// aboutBtn
			// 
			this.aboutBtn.FlatAppearance.BorderSize = 0;
			this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutBtn.Image = global::quick_sticky_notes.Properties.Resources.black_about;
			this.aboutBtn.Location = new System.Drawing.Point(0, 293);
			this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
			this.aboutBtn.Name = "aboutBtn";
			this.aboutBtn.Size = new System.Drawing.Size(32, 32);
			this.aboutBtn.TabIndex = 13;
			this.infoToolTip.SetToolTip(this.aboutBtn, "About (F1)");
			this.aboutBtn.UseVisualStyleBackColor = true;
			this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
			// 
			// settingsBtn
			// 
			this.settingsBtn.Enabled = false;
			this.settingsBtn.FlatAppearance.BorderSize = 0;
			this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
			this.settingsBtn.Location = new System.Drawing.Point(0, 325);
			this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.settingsBtn.Name = "settingsBtn";
			this.settingsBtn.Size = new System.Drawing.Size(32, 32);
			this.settingsBtn.TabIndex = 6;
			this.infoToolTip.SetToolTip(this.settingsBtn, "Settings (Ctrl+Comma)");
			this.settingsBtn.UseVisualStyleBackColor = true;
			// 
			// closeBtn
			// 
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.black_close;
			this.closeBtn.Location = new System.Drawing.Point(246, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 5;
			this.infoToolTip.SetToolTip(this.closeBtn, "Hide window (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
			// 
			// allNotesBtn
			// 
			this.allNotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allNotesBtn.Image = global::quick_sticky_notes.Properties.Resources.black_notes;
			this.allNotesBtn.Location = new System.Drawing.Point(0, 0);
			this.allNotesBtn.Margin = new System.Windows.Forms.Padding(0);
			this.allNotesBtn.Name = "allNotesBtn";
			this.allNotesBtn.Size = new System.Drawing.Size(32, 32);
			this.allNotesBtn.TabIndex = 7;
			this.sidebarToolTip.SetToolTip(this.allNotesBtn, "Without group (Ctrl+W)");
			this.allNotesBtn.UseVisualStyleBackColor = true;
			this.allNotesBtn.Click += new System.EventHandler(this.allNotesBtn_Click);
			// 
			// pinnedNotesBtn
			// 
			this.pinnedNotesBtn.Enabled = false;
			this.pinnedNotesBtn.FlatAppearance.BorderSize = 0;
			this.pinnedNotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pinnedNotesBtn.Image = global::quick_sticky_notes.Properties.Resources.black_pin;
			this.pinnedNotesBtn.Location = new System.Drawing.Point(0, 32);
			this.pinnedNotesBtn.Margin = new System.Windows.Forms.Padding(0);
			this.pinnedNotesBtn.Name = "pinnedNotesBtn";
			this.pinnedNotesBtn.Size = new System.Drawing.Size(32, 32);
			this.pinnedNotesBtn.TabIndex = 11;
			this.sidebarToolTip.SetToolTip(this.pinnedNotesBtn, "Pinned notes (Ctrl+P)");
			this.pinnedNotesBtn.UseVisualStyleBackColor = true;
			// 
			// trashBtn
			// 
			this.trashBtn.FlatAppearance.BorderSize = 0;
			this.trashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.trashBtn.Image = global::quick_sticky_notes.Properties.Resources.black_trash;
			this.trashBtn.Location = new System.Drawing.Point(0, 64);
			this.trashBtn.Margin = new System.Windows.Forms.Padding(0);
			this.trashBtn.Name = "trashBtn";
			this.trashBtn.Size = new System.Drawing.Size(32, 32);
			this.trashBtn.TabIndex = 12;
			this.sidebarToolTip.SetToolTip(this.trashBtn, "Trash (Ctrl+T)");
			this.trashBtn.UseVisualStyleBackColor = true;
			this.trashBtn.Click += new System.EventHandler(this.trashBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(35, 7);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(44, 17);
			this.titleLabel.TabIndex = 9;
			this.titleLabel.Text = "Tinote";
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(210)))));
			this.titlePanel.Controls.Add(this.logoPictureBox);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(279, 32);
			this.titlePanel.TabIndex = 10;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(32, 32);
			this.logoPictureBox.TabIndex = 13;
			this.logoPictureBox.TabStop = false;
			this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPictureBox_MouseDown);
			// 
			// sidePanel
			// 
			this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(225)))));
			this.sidePanel.Controls.Add(this.aboutBtn);
			this.sidePanel.Controls.Add(this.allNotesBtn);
			this.sidePanel.Controls.Add(this.pinnedNotesBtn);
			this.sidePanel.Controls.Add(this.trashBtn);
			this.sidePanel.Controls.Add(this.settingsBtn);
			this.sidePanel.Location = new System.Drawing.Point(0, 32);
			this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(32, 418);
			this.sidePanel.TabIndex = 13;
			// 
			// sidebarToolTip
			// 
			this.sidebarToolTip.AutomaticDelay = 0;
			this.sidebarToolTip.AutoPopDelay = 0;
			this.sidebarToolTip.InitialDelay = 0;
			this.sidebarToolTip.ReshowDelay = 0;
			this.sidebarToolTip.ToolTipTitle = "Group";
			// 
			// restoreToolStripMenuItem
			// 
			this.restoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.Image")));
			this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
			this.restoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.restoreToolStripMenuItem.Text = "Restore";
			this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
			// 
			// trashListItemContext
			// 
			this.trashListItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem});
			this.trashListItemContext.Name = "notesListContext";
			this.trashListItemContext.Size = new System.Drawing.Size(181, 48);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
			this.ClientSize = new System.Drawing.Size(278, 389);
			this.Controls.Add(this.sidePanel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.notesListBox);
			this.Controls.Add(this.searchPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tinote";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.notesListItemContext.ResumeLayout(false);
			this.notesListEmptyContext.ResumeLayout(false);
			this.trayContext.ResumeLayout(false);
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.sidePanel.ResumeLayout(false);
			this.trashListItemContext.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button profileBtn;
		private System.Windows.Forms.Button newNoteBtn;
		private System.Windows.Forms.ListBox notesListBox;
		private System.Windows.Forms.ContextMenuStrip notesListItemContext;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip notesListEmptyContext;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayContext;
		private System.Windows.Forms.ToolStripMenuItem notesListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.ToolTip infoToolTip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem changeColorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
		private System.Windows.Forms.Button settingsBtn;
		private System.Windows.Forms.Button allNotesBtn;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button pinnedNotesBtn;
		private System.Windows.Forms.Button trashBtn;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Panel sidePanel;
		private System.Windows.Forms.Button aboutBtn;
		private System.Windows.Forms.ToolTip sidebarToolTip;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip trashListItemContext;
	}
}

