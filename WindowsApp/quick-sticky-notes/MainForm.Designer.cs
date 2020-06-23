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
			this.profileBtn = new System.Windows.Forms.Button();
			this.newNoteBtn = new System.Windows.Forms.Button();
			this.notesListBox = new System.Windows.Forms.ListBox();
			this.notesListItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.titlePanel = new System.Windows.Forms.Panel();
			this.syncBtn = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.searchBtn = new System.Windows.Forms.Button();
			this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.changeColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesListItemContext.SuspendLayout();
			this.notesListEmptyContext.SuspendLayout();
			this.trayContext.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// profileBtn
			// 
			this.profileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.profileBtn.FlatAppearance.BorderSize = 0;
			this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
			this.profileBtn.Location = new System.Drawing.Point(196, 0);
			this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
			this.profileBtn.Name = "profileBtn";
			this.profileBtn.Size = new System.Drawing.Size(30, 30);
			this.profileBtn.TabIndex = 1;
			this.infoToolTip.SetToolTip(this.profileBtn, "Profile (Ctrl+P)");
			this.profileBtn.UseVisualStyleBackColor = true;
			this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
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
			this.newNoteBtn.TabIndex = 0;
			this.infoToolTip.SetToolTip(this.newNoteBtn, "New note (Ctrl+N)");
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// notesListBox
			// 
			this.notesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.notesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.notesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesListBox.FormattingEnabled = true;
			this.notesListBox.IntegralHeight = false;
			this.notesListBox.ItemHeight = 64;
			this.notesListBox.Location = new System.Drawing.Point(0, 60);
			this.notesListBox.Margin = new System.Windows.Forms.Padding(0);
			this.notesListBox.Name = "notesListBox";
			this.notesListBox.Size = new System.Drawing.Size(256, 329);
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
			this.notesListItemContext.Size = new System.Drawing.Size(181, 104);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
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
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.White;
			this.titlePanel.Controls.Add(this.syncBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.newNoteBtn);
			this.titlePanel.Controls.Add(this.profileBtn);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(256, 30);
			this.titlePanel.TabIndex = 3;
			this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
			// 
			// syncBtn
			// 
			this.syncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.syncBtn.FlatAppearance.BorderSize = 0;
			this.syncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.syncBtn.Image = ((System.Drawing.Image)(resources.GetObject("syncBtn.Image")));
			this.syncBtn.Location = new System.Drawing.Point(166, 0);
			this.syncBtn.Margin = new System.Windows.Forms.Padding(0);
			this.syncBtn.Name = "syncBtn";
			this.syncBtn.Size = new System.Drawing.Size(30, 30);
			this.syncBtn.TabIndex = 10;
			this.infoToolTip.SetToolTip(this.syncBtn, "Sync notes now (Ctrl+D)");
			this.syncBtn.UseVisualStyleBackColor = true;
			this.syncBtn.Visible = false;
			this.syncBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.Black;
			this.titleLabel.Location = new System.Drawing.Point(30, 6);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(44, 17);
			this.titleLabel.TabIndex = 9;
			this.titleLabel.Text = "Tinote";
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.black_close;
			this.closeBtn.Location = new System.Drawing.Point(226, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(30, 30);
			this.closeBtn.TabIndex = 2;
			this.infoToolTip.SetToolTip(this.closeBtn, "Close (Ctrl+Q)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.searchTextBox.Location = new System.Drawing.Point(30, 6);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(196, 18);
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
			this.searchPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.searchPanel.Controls.Add(this.searchBtn);
			this.searchPanel.Controls.Add(this.searchTextBox);
			this.searchPanel.Location = new System.Drawing.Point(0, 30);
			this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(256, 30);
			this.searchPanel.TabIndex = 5;
			// 
			// searchBtn
			// 
			this.searchBtn.FlatAppearance.BorderSize = 0;
			this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
			this.searchBtn.Location = new System.Drawing.Point(226, 0);
			this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(30, 30);
			this.searchBtn.TabIndex = 10;
			this.infoToolTip.SetToolTip(this.searchBtn, "Search");
			this.searchBtn.UseVisualStyleBackColor = true;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
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
			this.changeColorMenuItem.Size = new System.Drawing.Size(180, 22);
			this.changeColorMenuItem.Text = "Change color";
			// 
			// yellowToolStripMenuItem
			// 
			this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
			this.yellowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
			this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
			this.yellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.yellowToolStripMenuItem.Text = "Yellow";
			this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
			this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
			this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(97)))), ((int)(((byte)(127)))));
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// pinkToolStripMenuItem
			// 
			this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
			this.pinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
			this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
			this.pinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pinkToolStripMenuItem.Text = "Pink";
			this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
			// 
			// purpleToolStripMenuItem
			// 
			this.purpleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
			this.purpleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
			this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
			this.purpleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.purpleToolStripMenuItem.Text = "Purple";
			this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
			// 
			// whiteToolStripMenuItem
			// 
			this.whiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.whiteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
			this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
			this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.whiteToolStripMenuItem.Text = "White";
			this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(256, 389);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.notesListBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tinote";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.notesListItemContext.ResumeLayout(false);
			this.notesListEmptyContext.ResumeLayout(false);
			this.trayContext.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
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
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ToolTip infoToolTip;
		private System.Windows.Forms.Button syncBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem changeColorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
	}
}

