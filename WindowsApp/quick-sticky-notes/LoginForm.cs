using System;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			if (regMailTextBox.Text.Length > 0 && regPassTextBox.Text.Length > 0 && regPassTextBox.Text.Length > 0)
			{
				if (regPassTextBox.Text == regCpassTextBox.Text)
				{
					PerformRegistrationEventArgs args = new PerformRegistrationEventArgs
					{
						Email = regMailTextBox.Text,
						Password = regPassTextBox.Text
					};
					OnPerformRegistration(args);
				}
			}
		}

		protected virtual void OnPerformRegistration(PerformRegistrationEventArgs e)
		{
			PerformRegistration?.Invoke(this, e);
		}
		public event EventHandler<PerformRegistrationEventArgs> PerformRegistration;
	}

	public class PerformRegistrationEventArgs : EventArgs
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
