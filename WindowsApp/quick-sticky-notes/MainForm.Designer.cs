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
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesListEmptyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.syncPanel = new System.Windows.Forms.Panel();
			this.lastSyncLabel = new System.Windows.Forms.Label();
			this.profileLabel = new System.Windows.Forms.Label();
			this.syncBtn = new System.Windows.Forms.Button();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.notesListItemContext.SuspendLayout();
			this.notesListEmptyContext.SuspendLayout();
			this.trayContext.SuspendLayout();
			this.syncPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// profileBtn
			// 
			this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
			this.profileBtn.Location = new System.Drawing.Point(208, 9);
			this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
			this.profileBtn.Name = "profileBtn";
			this.profileBtn.Size = new System.Drawing.Size(23, 23);
			this.profileBtn.TabIndex = 1;
			this.profileBtn.UseVisualStyleBackColor = true;
			this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
			// 
			// newNoteBtn
			// 
			this.newNoteBtn.Location = new System.Drawing.Point(9, 9);
			this.newNoteBtn.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.newNoteBtn.Name = "newNoteBtn";
			this.newNoteBtn.Size = new System.Drawing.Size(190, 23);
			this.newNoteBtn.TabIndex = 0;
			this.newNoteBtn.Text = "New note";
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// notesListBox
			// 
			this.notesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.notesListBox.FormattingEnabled = true;
			this.notesListBox.ItemHeight = 15;
			this.notesListBox.Location = new System.Drawing.Point(9, 41);
			this.notesListBox.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.notesListBox.Name = "notesListBox";
			this.notesListBox.Size = new System.Drawing.Size(222, 272);
			this.notesListBox.TabIndex = 2;
			this.notesListBox.DoubleClick += new System.EventHandler(this.notesListBox_DoubleClick_1);
			this.notesListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notesListBox_MouseUp);
			// 
			// notesListItemContext
			// 
			this.notesListItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.notesListItemContext.Name = "notesListContext";
			this.notesListItemContext.Size = new System.Drawing.Size(148, 48);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.renameToolStripMenuItem.Text = "Edit";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
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
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.addNoteToolStripMenuItem.Text = "Add note";
			this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayContext;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "Quick Sticky Notes";
			this.trayIcon.Visible = true;
			this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
			// 
			// trayContext
			// 
			this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.trayContext.Name = "notesListContext";
			this.trayContext.Size = new System.Drawing.Size(124, 54);
			// 
			// notesListToolStripMenuItem
			// 
			this.notesListToolStripMenuItem.Name = "notesListToolStripMenuItem";
			this.notesListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.notesListToolStripMenuItem.Text = "Notes list";
			this.notesListToolStripMenuItem.Click += new System.EventHandler(this.notesListToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// syncPanel
			// 
			this.syncPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.syncPanel.Controls.Add(this.lastSyncLabel);
			this.syncPanel.Controls.Add(this.profileLabel);
			this.syncPanel.Controls.Add(this.syncBtn);
			this.syncPanel.Location = new System.Drawing.Point(-1, 232);
			this.syncPanel.Margin = new System.Windows.Forms.Padding(0);
			this.syncPanel.Name = "syncPanel";
			this.syncPanel.Size = new System.Drawing.Size(242, 91);
			this.syncPanel.TabIndex = 10;
			this.syncPanel.Visible = false;
			// 
			// lastSyncLabel
			// 
			this.lastSyncLabel.AutoSize = true;
			this.lastSyncLabel.Location = new System.Drawing.Point(12, 33);
			this.lastSyncLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
			this.lastSyncLabel.Name = "lastSyncLabel";
			this.lastSyncLabel.Size = new System.Drawing.Size(150, 15);
			this.lastSyncLabel.TabIndex = 3;
			this.lastSyncLabel.Text = "Unauthorized, please log in";
			// 
			// profileLabel
			// 
			this.profileLabel.AutoSize = true;
			this.profileLabel.Location = new System.Drawing.Point(12, 9);
			this.profileLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
			this.profileLabel.Name = "profileLabel";
			this.profileLabel.Size = new System.Drawing.Size(113, 15);
			this.profileLabel.TabIndex = 2;
			this.profileLabel.Text = "Sync is not available";
			// 
			// syncBtn
			// 
			this.syncBtn.Location = new System.Drawing.Point(9, 57);
			this.syncBtn.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.syncBtn.Name = "syncBtn";
			this.syncBtn.Size = new System.Drawing.Size(222, 23);
			this.syncBtn.TabIndex = 1;
			this.syncBtn.Text = "Sign in to Google";
			this.syncBtn.UseVisualStyleBackColor = true;
			this.syncBtn.Click += new System.EventHandler(this.syncButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(240, 322);
			this.Controls.Add(this.syncPanel);
			this.Controls.Add(this.notesListBox);
			this.Controls.Add(this.newNoteBtn);
			this.Controls.Add(this.profileBtn);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Sticky Notes";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.notesListItemContext.ResumeLayout(false);
			this.notesListEmptyContext.ResumeLayout(false);
			this.trayContext.ResumeLayout(false);
			this.syncPanel.ResumeLayout(false);
			this.syncPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button profileBtn;
		private System.Windows.Forms.Button newNoteBtn;
		private System.Windows.Forms.ListBox notesListBox;
		private System.Windows.Forms.ContextMenuStrip notesListItemContext;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip notesListEmptyContext;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayContext;
		private System.Windows.Forms.ToolStripMenuItem notesListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel syncPanel;
		private System.Windows.Forms.Button syncBtn;
		private System.Windows.Forms.Label profileLabel;
		private System.Windows.Forms.Label lastSyncLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

