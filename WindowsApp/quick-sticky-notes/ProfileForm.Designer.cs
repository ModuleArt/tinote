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
			this.syncBtn = new System.Windows.Forms.Button();
			this.loggedAsLabel = new System.Windows.Forms.Label();
			this.mailLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// logoutBtn
			// 
			this.logoutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.logoutBtn.FlatAppearance.BorderSize = 0;
			this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
			this.logoutBtn.Location = new System.Drawing.Point(210, 122);
			this.logoutBtn.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
			this.logoutBtn.Name = "logoutBtn";
			this.logoutBtn.Size = new System.Drawing.Size(112, 30);
			this.logoutBtn.TabIndex = 0;
			this.logoutBtn.Text = "Sign out";
			this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.logoutBtn.UseVisualStyleBackColor = false;
			this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(114, 43);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(117, 21);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Display Name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// syncBtn
			// 
			this.syncBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.syncBtn.FlatAppearance.BorderSize = 0;
			this.syncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.syncBtn.Image = ((System.Drawing.Image)(resources.GetObject("syncBtn.Image")));
			this.syncBtn.Location = new System.Drawing.Point(9, 122);
			this.syncBtn.Margin = new System.Windows.Forms.Padding(0);
			this.syncBtn.Name = "syncBtn";
			this.syncBtn.Size = new System.Drawing.Size(192, 30);
			this.syncBtn.TabIndex = 3;
			this.syncBtn.Text = "Sync everything now";
			this.syncBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.syncBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.syncBtn.UseVisualStyleBackColor = false;
			this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
			// 
			// loggedAsLabel
			// 
			this.loggedAsLabel.AutoSize = true;
			this.loggedAsLabel.Location = new System.Drawing.Point(114, 17);
			this.loggedAsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.loggedAsLabel.Name = "loggedAsLabel";
			this.loggedAsLabel.Size = new System.Drawing.Size(87, 17);
			this.loggedAsLabel.TabIndex = 4;
			this.loggedAsLabel.Text = "Logged in as:";
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(115, 73);
			this.mailLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(96, 17);
			this.mailLabel.TabIndex = 5;
			this.mailLabel.Text = "mail@mail.com";
			// 
			// ProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(331, 161);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.loggedAsLabel);
			this.Controls.Add(this.syncBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.logoutBtn);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Profile";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button logoutBtn;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button syncBtn;
		private System.Windows.Forms.Label loggedAsLabel;
		private System.Windows.Forms.Label mailLabel;
	}
}