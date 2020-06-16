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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.closeBtn = new System.Windows.Forms.Button();
			this.notesListItemContext.SuspendLayout();
			this.notesListEmptyContext.SuspendLayout();
			this.trayContext.SuspendLayout();
			this.titlePanel.SuspendLayout();
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
			this.newNoteBtn.UseVisualStyleBackColor = true;
			this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
			// 
			// notesListBox
			// 
			this.notesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.notesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesListBox.FormattingEnabled = true;
			this.notesListBox.ItemHeight = 17;
			this.notesListBox.Location = new System.Drawing.Point(9, 39);
			this.notesListBox.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.notesListBox.Name = "notesListBox";
			this.notesListBox.Size = new System.Drawing.Size(238, 308);
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
			this.notesListItemContext.Size = new System.Drawing.Size(108, 48);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.renameToolStripMenuItem.Text = "Edit";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
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
			this.notesListToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.notesListToolStripMenuItem.Text = "Notes list";
			this.notesListToolStripMenuItem.Click += new System.EventHandler(this.notesListToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.White;
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
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.Location = new System.Drawing.Point(226, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(30, 30);
			this.closeBtn.TabIndex = 2;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(256, 357);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.notesListBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Sticky Notes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.notesListItemContext.ResumeLayout(false);
			this.notesListEmptyContext.ResumeLayout(false);
			this.trayContext.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button closeBtn;
	}
}

