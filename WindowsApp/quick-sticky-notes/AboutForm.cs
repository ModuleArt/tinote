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
				CreateParams cp = base.CreateParams;
				cp.Style = NativeMethodsManager.WS_SYSMENU;
				cp.ClassStyle |= NativeMethodsManager.CS_DROPSHADOW;
				return cp;
			}
		}

		public AboutForm()
		{
			InitializeComponent();

			string fullVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			int lastDotIndex = fullVer.LastIndexOf('.');
			versionLabel.Text = String.Format(versionLabel.Text, fullVer.Substring(0, lastDotIndex));
			if (IntPtr.Size == 4)
			{
				versionLabel.Text += " (x32)";
			}
			else if (IntPtr.Size == 8)
			{
				versionLabel.Text += " (x64)";
			}
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

		private void donateBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.patreon.com/moduleart");
		}
	}
}
