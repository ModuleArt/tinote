namespace quick_sticky_notes
{
	partial class NotePanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePanel));
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
			this.leftAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.centerAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rmbContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(200, 200);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
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
            this.leftAlignToolStripMenuItem,
            this.centerAlignToolStripMenuItem,
            this.rightAlignToolStripMenuItem});
			this.rmbContext.Name = "rmbContext";
			this.rmbContext.Size = new System.Drawing.Size(248, 374);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// pasteAsPlainTextToolStripMenuItem
			// 
			this.pasteAsPlainTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteAsPlainTextToolStripMenuItem.Image")));
			this.pasteAsPlainTextToolStripMenuItem.Name = "pasteAsPlainTextToolStripMenuItem";
			this.pasteAsPlainTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
			this.pasteAsPlainTextToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.pasteAsPlainTextToolStripMenuItem.Text = "Paste as plain text";
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.selectAllToolStripMenuItem.Text = "Select all";
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
			// 
			// boldToolStripMenuItem
			// 
			this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
			this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.boldToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.boldToolStripMenuItem.Text = "Bold";
			// 
			// italicToolStripMenuItem
			// 
			this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
			this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.italicToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.italicToolStripMenuItem.Text = "Italic";
			// 
			// underlineToolStripMenuItem
			// 
			this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
			this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
			this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.underlineToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.underlineToolStripMenuItem.Text = "Underline";
			// 
			// strikethroughToolStripMenuItem
			// 
			this.strikethroughToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("strikethroughToolStripMenuItem.Image")));
			this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
			this.strikethroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.strikethroughToolStripMenuItem.Text = "Strikethrough";
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
			// 
			// superscriptToolStripMenuItem
			// 
			this.superscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("superscriptToolStripMenuItem.Image")));
			this.superscriptToolStripMenuItem.Name = "superscriptToolStripMenuItem";
			this.superscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
			this.superscriptToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.superscriptToolStripMenuItem.Text = "Superscript";
			// 
			// subscriptToolStripMenuItem
			// 
			this.subscriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subscriptToolStripMenuItem.Image")));
			this.subscriptToolStripMenuItem.Name = "subscriptToolStripMenuItem";
			this.subscriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.subscriptToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.subscriptToolStripMenuItem.Text = "Subscript";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
			// 
			// leftAlignToolStripMenuItem
			// 
			this.leftAlignToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignToolStripMenuItem.Image")));
			this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
			this.leftAlignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.leftAlignToolStripMenuItem.Text = "Left align";
			// 
			// centerAlignToolStripMenuItem
			// 
			this.centerAlignToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignToolStripMenuItem.Image")));
			this.centerAlignToolStripMenuItem.Name = "centerAlignToolStripMenuItem";
			this.centerAlignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.centerAlignToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.centerAlignToolStripMenuItem.Text = "Center align";
			// 
			// rightAlignToolStripMenuItem
			// 
			this.rightAlignToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignToolStripMenuItem.Image")));
			this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
			this.rightAlignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.rightAlignToolStripMenuItem.Text = "Right align";
			// 
			// NotePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.richTextBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NotePanel";
			this.Size = new System.Drawing.Size(200, 200);
			this.rmbContext.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ContextMenuStrip rmbContext;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteAsPlainTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toggleBulletsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem capitalizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem superscriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem subscriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centerAlignToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem;
	}
}
