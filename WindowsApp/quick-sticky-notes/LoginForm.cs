using System;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class LoginForm : Form
	{
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.Style = NativeMethodsManager.WS_SYSMENU;
				cp.ClassStyle |= NativeMethodsManager.CS_DROPSHADOW;
				return cp;
			}
		}

		public LoginForm()
		{
			InitializeComponent();
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			if (regNameTextBox.Text.Length > 0 && regMailTextBox.Text.Length > 0 && regPassTextBox.Text.Length > 0 && regCpassTextBox.Text.Length > 0)
			{
				if (String.Equals(regPassTextBox.Text, regCpassTextBox.Text))
				{
					this.Close();
					PerformRegistrationEventArgs args = new PerformRegistrationEventArgs
					{
						DisplayName = regNameTextBox.Text,
						Email = regMailTextBox.Text,
						Password = regPassTextBox.Text
					};
					OnPerformRegistration(args);
				}
				else
				{
					MessageBox.Show("Password mismatch", "Error");
				}
			}
			else
			{
				MessageBox.Show("Fill in all the fields", "Error");
			}
		}

		protected virtual void OnPerformRegistration(PerformRegistrationEventArgs e)
		{
			PerformRegistration?.Invoke(this, e);
		}
		public event EventHandler<PerformRegistrationEventArgs> PerformRegistration;

		protected virtual void OnPerformLogin(PerformLoginEventArgs e)
		{
			PerformLogin?.Invoke(this, e);
		}
		public event EventHandler<PerformLoginEventArgs> PerformLogin;

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if (loginMailTextBox.Text.Length > 0 && loginPassTextBox.Text.Length > 0)
			{
				this.Close();
				PerformLoginEventArgs args = new PerformLoginEventArgs
				{
					Email = loginMailTextBox.Text,
					Password = loginPassTextBox.Text
				};
				OnPerformLogin(args);
			}
			else
			{
				MessageBox.Show("Fill in all the fields", "Error");
			}
		}
	}

	public class PerformRegistrationEventArgs : EventArgs
	{
		public string DisplayName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}

	public class PerformLoginEventArgs : EventArgs
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
