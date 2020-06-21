using System;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class ProfileForm : Form
	{
		public ProfileForm(string displayName, string email)
		{
			InitializeComponent();

			nameLabel.Text = displayName;
			mailLabel.Text = email;
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			OnPerformSignOut(e);
		}

		private void syncBtn_Click(object sender, EventArgs e)
		{
			OnPerformSync(e);
		}

		protected virtual void OnPerformSync(EventArgs e)
		{
			PerformSync?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> PerformSync;

		protected virtual void OnPerformSignOut(EventArgs e)
		{
			PerformSignOut?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> PerformSignOut;
	}
}
