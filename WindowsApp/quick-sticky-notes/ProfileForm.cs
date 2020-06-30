using System;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class ProfileForm : Form
	{
		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_DROPSHADOW = 0x20000;
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		public ProfileForm(string displayName, string email)
		{
			InitializeComponent();

			nameLabel.Text = displayName;
			mailLabel.Text = email;
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			OnPerformSignOut(e);
			this.Close();
		}

		protected virtual void OnPerformSignOut(EventArgs e)
		{
			PerformSignOut?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> PerformSignOut;

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void closeBtn_MouseEnter(object sender, EventArgs e)
		{
			closeBtn.Image = Properties.Resources.white_close;
		}

		private void closeBtn_MouseLeave(object sender, EventArgs e)
		{
			closeBtn.Image = Properties.Resources.black_close;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			ProfileForm_MouseDown(sender, e);
		}

		private void ProfileForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeAll;
				NativeMethodsManager.ReleaseCapture();
				NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
			}
		}

		private void loggedAsLabel_MouseDown(object sender, MouseEventArgs e)
		{
			ProfileForm_MouseDown(sender, e);
		}

		private void nameLabel_MouseDown(object sender, MouseEventArgs e)
		{
			ProfileForm_MouseDown(sender, e);
		}

		private void mailLabel_MouseDown(object sender, MouseEventArgs e)
		{
			ProfileForm_MouseDown(sender, e);
		}
	}
}
