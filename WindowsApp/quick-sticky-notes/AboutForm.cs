using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class AboutForm : Form
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

		public AboutForm()
		{
			InitializeComponent();

			string fullVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			int lastDotIndex = fullVer.LastIndexOf('.');
			versionLabel.Text = String.Format(versionLabel.Text, fullVer.Substring(0, lastDotIndex));
		}

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

		private void AboutForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeAll;
				NativeMethodsManager.ReleaseCapture();
				NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			AboutForm_MouseDown(sender, e);
		}

		private void titleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			AboutForm_MouseDown(sender, e);
		}

		private void versionLabel_MouseDown(object sender, MouseEventArgs e)
		{
			AboutForm_MouseDown(sender, e);
		}

		private void copyrightBtn_MouseDown(object sender, MouseEventArgs e)
		{
			AboutForm_MouseDown(sender, e);
		}

		private void githubBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/tinote");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://moduleart.github.io/");
		}
	}
}
