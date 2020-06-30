namespace quick_sticky_notes
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.loginPage = new System.Windows.Forms.TabPage();
			this.loginBtn = new System.Windows.Forms.Button();
			this.loginPassTextBox = new System.Windows.Forms.TextBox();
			this.loginPassLabel = new System.Windows.Forms.Label();
			this.loginMailLabel = new System.Windows.Forms.Label();
			this.loginMailTextBox = new System.Windows.Forms.TextBox();
			this.registrationPage = new System.Windows.Forms.TabPage();
			this.regNameTextBox = new System.Windows.Forms.TextBox();
			this.regNameLabel = new System.Windows.Forms.Label();
			this.registerBtn = new System.Windows.Forms.Button();
			this.regCpassTextBox = new System.Windows.Forms.TextBox();
			this.regCpassLabel = new System.Windows.Forms.Label();
			this.regPassTextBox = new System.Windows.Forms.TextBox();
			this.regPassLabel = new System.Windows.Forms.Label();
			this.regMailLabel = new System.Windows.Forms.Label();
			this.regMailTextBox = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.loginPage.SuspendLayout();
			this.registrationPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.loginPage);
			this.tabControl1.Controls.Add(this.registrationPage);
			this.tabControl1.Location = new System.Drawing.Point(9, 9);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(306, 323);
			this.tabControl1.TabIndex = 0;
			// 
			// loginPage
			// 
			this.loginPage.Controls.Add(this.loginBtn);
			this.loginPage.Controls.Add(this.loginPassTextBox);
			this.loginPage.Controls.Add(this.loginPassLabel);
			this.loginPage.Controls.Add(this.loginMailLabel);
			this.loginPage.Controls.Add(this.loginMailTextBox);
			this.loginPage.Location = new System.Drawing.Point(4, 26);
			this.loginPage.Margin = new System.Windows.Forms.Padding(0);
			this.loginPage.Name = "loginPage";
			this.loginPage.Size = new System.Drawing.Size(298, 293);
			this.loginPage.TabIndex = 1;
			this.loginPage.Text = "Login";
			this.loginPage.UseVisualStyleBackColor = true;
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.loginBtn.FlatAppearance.BorderSize = 0;
			this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
			this.loginBtn.Location = new System.Drawing.Point(193, 257);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(9);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(96, 27);
			this.loginBtn.TabIndex = 11;
			this.loginBtn.Text = "Sign in";
			this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// loginPassTextBox
			// 
			this.loginPassTextBox.Location = new System.Drawing.Point(9, 89);
			this.loginPassTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.loginPassTextBox.Name = "loginPassTextBox";
			this.loginPassTextBox.Size = new System.Drawing.Size(280, 25);
			this.loginPassTextBox.TabIndex = 10;
			// 
			// loginPassLabel
			// 
			this.loginPassLabel.AutoSize = true;
			this.loginPassLabel.Location = new System.Drawing.Point(9, 65);
			this.loginPassLabel.Margin = new System.Windows.Forms.Padding(9);
			this.loginPassLabel.Name = "loginPassLabel";
			this.loginPassLabel.Size = new System.Drawing.Size(67, 17);
			this.loginPassLabel.TabIndex = 9;
			this.loginPassLabel.Text = "Password:";
			// 
			// loginMailLabel
			// 
			this.loginMailLabel.AutoSize = true;
			this.loginMailLabel.Location = new System.Drawing.Point(9, 9);
			this.loginMailLabel.Margin = new System.Windows.Forms.Padding(9);
			this.loginMailLabel.Name = "loginMailLabel";
			this.loginMailLabel.Size = new System.Drawing.Size(42, 17);
			this.loginMailLabel.TabIndex = 8;
			this.loginMailLabel.Text = "Email:";
			// 
			// loginMailTextBox
			// 
			this.loginMailTextBox.Location = new System.Drawing.Point(9, 33);
			this.loginMailTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.loginMailTextBox.Name = "loginMailTextBox";
			this.loginMailTextBox.Size = new System.Drawing.Size(280, 25);
			this.loginMailTextBox.TabIndex = 7;
			// 
			// registrationPage
			// 
			this.registrationPage.Controls.Add(this.regNameTextBox);
			this.registrationPage.Controls.Add(this.regNameLabel);
			this.registrationPage.Controls.Add(this.registerBtn);
			this.registrationPage.Controls.Add(this.regCpassTextBox);
			this.registrationPage.Controls.Add(this.regCpassLabel);
			this.registrationPage.Controls.Add(this.regPassTextBox);
			this.registrationPage.Controls.Add(this.regPassLabel);
			this.registrationPage.Controls.Add(this.regMailLabel);
			this.registrationPage.Controls.Add(this.regMailTextBox);
			this.registrationPage.Location = new System.Drawing.Point(4, 26);
			this.registrationPage.Margin = new System.Windows.Forms.Padding(0);
			this.registrationPage.Name = "registrationPage";
			this.registrationPage.Size = new System.Drawing.Size(298, 293);
			this.registrationPage.TabIndex = 0;
			this.registrationPage.Text = "Register";
			this.registrationPage.UseVisualStyleBackColor = true;
			// 
			// regNameTextBox
			// 
			this.regNameTextBox.Location = new System.Drawing.Point(9, 33);
			this.regNameTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regNameTextBox.Name = "regNameTextBox";
			this.regNameTextBox.Size = new System.Drawing.Size(280, 25);
			this.regNameTextBox.TabIndex = 8;
			// 
			// regNameLabel
			// 
			this.regNameLabel.AutoSize = true;
			this.regNameLabel.Location = new System.Drawing.Point(9, 9);
			this.regNameLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regNameLabel.Name = "regNameLabel";
			this.regNameLabel.Size = new System.Drawing.Size(46, 17);
			this.regNameLabel.TabIndex = 7;
			this.regNameLabel.Text = "Name:";
			// 
			// registerBtn
			// 
			this.registerBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.registerBtn.FlatAppearance.BorderSize = 0;
			this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerBtn.Image = ((System.Drawing.Image)(resources.GetObject("registerBtn.Image")));
			this.registerBtn.Location = new System.Drawing.Point(193, 257);
			this.registerBtn.Margin = new System.Windows.Forms.Padding(9);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(96, 27);
			this.registerBtn.TabIndex = 6;
			this.registerBtn.Text = "Sign up";
			this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.registerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// regCpassTextBox
			// 
			this.regCpassTextBox.Location = new System.Drawing.Point(9, 201);
			this.regCpassTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regCpassTextBox.Name = "regCpassTextBox";
			this.regCpassTextBox.Size = new System.Drawing.Size(280, 25);
			this.regCpassTextBox.TabIndex = 5;
			// 
			// regCpassLabel
			// 
			this.regCpassLabel.AutoSize = true;
			this.regCpassLabel.Location = new System.Drawing.Point(9, 177);
			this.regCpassLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regCpassLabel.Name = "regCpassLabel";
			this.regCpassLabel.Size = new System.Drawing.Size(118, 17);
			this.regCpassLabel.TabIndex = 4;
			this.regCpassLabel.Text = "Confirm password:";
			// 
			// regPassTextBox
			// 
			this.regPassTextBox.Location = new System.Drawing.Point(12, 145);
			this.regPassTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regPassTextBox.Name = "regPassTextBox";
			this.regPassTextBox.Size = new System.Drawing.Size(277, 25);
			this.regPassTextBox.TabIndex = 3;
			// 
			// regPassLabel
			// 
			this.regPassLabel.AutoSize = true;
			this.regPassLabel.Location = new System.Drawing.Point(9, 121);
			this.regPassLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regPassLabel.Name = "regPassLabel";
			this.regPassLabel.Size = new System.Drawing.Size(67, 17);
			this.regPassLabel.TabIndex = 2;
			this.regPassLabel.Text = "Password:";
			// 
			// regMailLabel
			// 
			this.regMailLabel.AutoSize = true;
			this.regMailLabel.Location = new System.Drawing.Point(9, 65);
			this.regMailLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regMailLabel.Name = "regMailLabel";
			this.regMailLabel.Size = new System.Drawing.Size(42, 17);
			this.regMailLabel.TabIndex = 1;
			this.regMailLabel.Text = "Email:";
			// 
			// regMailTextBox
			// 
			this.regMailTextBox.Location = new System.Drawing.Point(9, 89);
			this.regMailTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regMailTextBox.Name = "regMailTextBox";
			this.regMailTextBox.Size = new System.Drawing.Size(280, 25);
			this.regMailTextBox.TabIndex = 0;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(324, 341);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Register / Login";
			this.tabControl1.ResumeLayout(false);
			this.loginPage.ResumeLayout(false);
			this.loginPage.PerformLayout();
			this.registrationPage.ResumeLayout(false);
			this.registrationPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage registrationPage;
		private System.Windows.Forms.TabPage loginPage;
		private System.Windows.Forms.TextBox regMailTextBox;
		private System.Windows.Forms.Label regMailLabel;
		private System.Windows.Forms.Label regPassLabel;
		private System.Windows.Forms.TextBox regPassTextBox;
		private System.Windows.Forms.TextBox regCpassTextBox;
		private System.Windows.Forms.Label regCpassLabel;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.TextBox loginPassTextBox;
		private System.Windows.Forms.Label loginPassLabel;
		private System.Windows.Forms.Label loginMailLabel;
		private System.Windows.Forms.TextBox loginMailTextBox;
		private System.Windows.Forms.Label regNameLabel;
		private System.Windows.Forms.TextBox regNameTextBox;
	}
}