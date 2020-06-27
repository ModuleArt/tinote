namespace quick_sticky_notes
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.titleLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.githubBtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.closeBtn = new System.Windows.Forms.Button();
			this.copyrightBtn = new System.Windows.Forms.Label();
			this.developerBtn = new System.Windows.Forms.Button();
			this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(9, 178);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(238, 21);
			this.titleLabel.TabIndex = 13;
			this.titleLabel.Text = "Tinote";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
			// 
			// versionLabel
			// 
			this.versionLabel.Location = new System.Drawing.Point(9, 208);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(238, 17);
			this.versionLabel.TabIndex = 14;
			this.versionLabel.Text = "Sticky Notes v{0}";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.versionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.versionLabel_MouseDown);
			// 
			// githubBtn
			// 
			this.githubBtn.FlatAppearance.BorderSize = 0;
			this.githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.githubBtn.Image = global::quick_sticky_notes.Properties.Resources.black_github;
			this.githubBtn.Location = new System.Drawing.Point(9, 266);
			this.githubBtn.Margin = new System.Windows.Forms.Padding(0, 32, 0, 9);
			this.githubBtn.Name = "githubBtn";
			this.githubBtn.Size = new System.Drawing.Size(110, 32);
			this.githubBtn.TabIndex = 15;
			this.githubBtn.Text = " Contribute";
			this.githubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.githubBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.githubBtn.UseVisualStyleBackColor = true;
			this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 41);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(238, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.black_close;
			this.closeBtn.Location = new System.Drawing.Point(224, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 5;
			this.infoToolTip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
			// 
			// copyrightBtn
			// 
			this.copyrightBtn.Location = new System.Drawing.Point(9, 316);
			this.copyrightBtn.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.copyrightBtn.Name = "copyrightBtn";
			this.copyrightBtn.Size = new System.Drawing.Size(238, 17);
			this.copyrightBtn.TabIndex = 16;
			this.copyrightBtn.Text = "© 2020 Module Art";
			this.copyrightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.copyrightBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.copyrightBtn_MouseDown);
			// 
			// developerBtn
			// 
			this.developerBtn.FlatAppearance.BorderSize = 0;
			this.developerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.developerBtn.Image = ((System.Drawing.Image)(resources.GetObject("developerBtn.Image")));
			this.developerBtn.Location = new System.Drawing.Point(137, 266);
			this.developerBtn.Margin = new System.Windows.Forms.Padding(0, 32, 0, 9);
			this.developerBtn.Name = "developerBtn";
			this.developerBtn.Size = new System.Drawing.Size(110, 32);
			this.developerBtn.TabIndex = 17;
			this.developerBtn.Text = " Module Art";
			this.developerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.developerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.developerBtn.UseVisualStyleBackColor = true;
			this.developerBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(56)))));
			this.ClientSize = new System.Drawing.Size(256, 351);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.developerBtn);
			this.Controls.Add(this.copyrightBtn);
			this.Controls.Add(this.githubBtn);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutForm";
			this.TopMost = true;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Button githubBtn;
		private System.Windows.Forms.Label copyrightBtn;
		private System.Windows.Forms.Button developerBtn;
		private System.Windows.Forms.ToolTip infoToolTip;
	}
}