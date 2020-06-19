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
			this.registrationPage = new System.Windows.Forms.TabPage();
			this.registerBtn = new System.Windows.Forms.Button();
			this.regCpassTextBox = new System.Windows.Forms.TextBox();
			this.regCpassLabel = new System.Windows.Forms.Label();
			this.regPassTextBox = new System.Windows.Forms.TextBox();
			this.regPassLabel = new System.Windows.Forms.Label();
			this.regMailLabel = new System.Windows.Forms.Label();
			this.regMailTextBox = new System.Windows.Forms.TextBox();
			this.loginPage = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.registrationPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.registrationPage);
			this.tabControl1.Controls.Add(this.loginPage);
			this.tabControl1.Location = new System.Drawing.Point(9, 9);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(222, 263);
			this.tabControl1.TabIndex = 0;
			// 
			// registrationPage
			// 
			this.registrationPage.Controls.Add(this.registerBtn);
			this.registrationPage.Controls.Add(this.regCpassTextBox);
			this.registrationPage.Controls.Add(this.regCpassLabel);
			this.registrationPage.Controls.Add(this.regPassTextBox);
			this.registrationPage.Controls.Add(this.regPassLabel);
			this.registrationPage.Controls.Add(this.regMailLabel);
			this.registrationPage.Controls.Add(this.regMailTextBox);
			this.registrationPage.Location = new System.Drawing.Point(4, 24);
			this.registrationPage.Margin = new System.Windows.Forms.Padding(0);
			this.registrationPage.Name = "registrationPage";
			this.registrationPage.Size = new System.Drawing.Size(214, 235);
			this.registrationPage.TabIndex = 0;
			this.registrationPage.Text = "Register";
			this.registrationPage.UseVisualStyleBackColor = true;
			// 
			// registerBtn
			// 
			this.registerBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerBtn.Location = new System.Drawing.Point(5, 199);
			this.registerBtn.Margin = new System.Windows.Forms.Padding(9);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(200, 27);
			this.registerBtn.TabIndex = 6;
			this.registerBtn.Text = "Sign Up";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// regCpassTextBox
			// 
			this.regCpassTextBox.Location = new System.Drawing.Point(5, 145);
			this.regCpassTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regCpassTextBox.Name = "regCpassTextBox";
			this.regCpassTextBox.Size = new System.Drawing.Size(200, 23);
			this.regCpassTextBox.TabIndex = 5;
			// 
			// regCpassLabel
			// 
			this.regCpassLabel.AutoSize = true;
			this.regCpassLabel.Location = new System.Drawing.Point(5, 121);
			this.regCpassLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regCpassLabel.Name = "regCpassLabel";
			this.regCpassLabel.Size = new System.Drawing.Size(107, 15);
			this.regCpassLabel.TabIndex = 4;
			this.regCpassLabel.Text = "Confirm password:";
			// 
			// regPassTextBox
			// 
			this.regPassTextBox.Location = new System.Drawing.Point(5, 89);
			this.regPassTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regPassTextBox.Name = "regPassTextBox";
			this.regPassTextBox.Size = new System.Drawing.Size(200, 23);
			this.regPassTextBox.TabIndex = 3;
			// 
			// regPassLabel
			// 
			this.regPassLabel.AutoSize = true;
			this.regPassLabel.Location = new System.Drawing.Point(5, 65);
			this.regPassLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regPassLabel.Name = "regPassLabel";
			this.regPassLabel.Size = new System.Drawing.Size(60, 15);
			this.regPassLabel.TabIndex = 2;
			this.regPassLabel.Text = "Password:";
			// 
			// regMailLabel
			// 
			this.regMailLabel.AutoSize = true;
			this.regMailLabel.Location = new System.Drawing.Point(5, 9);
			this.regMailLabel.Margin = new System.Windows.Forms.Padding(9);
			this.regMailLabel.Name = "regMailLabel";
			this.regMailLabel.Size = new System.Drawing.Size(39, 15);
			this.regMailLabel.TabIndex = 1;
			this.regMailLabel.Text = "Email:";
			// 
			// regMailTextBox
			// 
			this.regMailTextBox.Location = new System.Drawing.Point(5, 33);
			this.regMailTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.regMailTextBox.Name = "regMailTextBox";
			this.regMailTextBox.Size = new System.Drawing.Size(200, 23);
			this.regMailTextBox.TabIndex = 0;
			// 
			// loginPage
			// 
			this.loginPage.Location = new System.Drawing.Point(4, 24);
			this.loginPage.Name = "loginPage";
			this.loginPage.Padding = new System.Windows.Forms.Padding(3);
			this.loginPage.Size = new System.Drawing.Size(214, 235);
			this.loginPage.TabIndex = 1;
			this.loginPage.Text = "Login";
			this.loginPage.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(240, 281);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.Text = "Register / Login";
			this.tabControl1.ResumeLayout(false);
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
	}
}