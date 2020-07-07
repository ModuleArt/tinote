namespace quick_sticky_notes
{
	partial class ProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
			this.logoutBtn = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loggedAsLabel = new System.Windows.Forms.Label();
			this.mailLabel = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// logoutBtn
			// 
			this.logoutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.logoutBtn.FlatAppearance.BorderSize = 0;
			this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
			this.logoutBtn.Location = new System.Drawing.Point(129, 251);
			this.logoutBtn.Margin = new System.Windows.Forms.Padding(0, 32, 0, 0);
			this.logoutBtn.Name = "logoutBtn";
			this.logoutBtn.Size = new System.Drawing.Size(118, 30);
			this.logoutBtn.TabIndex = 1;
			this.logoutBtn.Text = "Sign out";
			this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.logoutBtn.UseVisualStyleBackColor = false;
			this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(9, 163);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(238, 21);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Display Name";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 32);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(238, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// loggedAsLabel
			// 
			this.loggedAsLabel.Location = new System.Drawing.Point(9, 137);
			this.loggedAsLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.loggedAsLabel.Name = "loggedAsLabel";
			this.loggedAsLabel.Size = new System.Drawing.Size(238, 17);
			this.loggedAsLabel.TabIndex = 4;
			this.loggedAsLabel.Text = "Logged in as:";
			this.loggedAsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.loggedAsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loggedAsLabel_MouseDown);
			// 
			// mailLabel
			// 
			this.mailLabel.Location = new System.Drawing.Point(9, 193);
			this.mailLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(238, 17);
			this.mailLabel.TabIndex = 5;
			this.mailLabel.Text = "mail@mail.com";
			this.mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mailLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mailLabel_MouseDown);
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
			this.closeBtn.TabIndex = 0;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
			// 
			// ProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(256, 290);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.loggedAsLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.logoutBtn);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProfileForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Profile";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button logoutBtn;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label loggedAsLabel;
		private System.Windows.Forms.Label mailLabel;
		private System.Windows.Forms.Button closeBtn;
	}
}