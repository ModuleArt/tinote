using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class NoteForm : Form
	{
		private DateTime dateModified;
		private string colorStr;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr FindWindowEx(IntPtr hP, IntPtr hC, string sC, string sW);

		private System.Timers.Timer resizeTimer = new System.Timers.Timer();

		private Point startPos;
		private Size curSize;

		public NoteForm(string title, string content, DateTime dateModified)
		{
			InitializeComponent();

			this.Text = title;
			this.dateModified = dateModified;

			try
			{
				richTextBox1.Rtf = content;
			}
			catch
			{
				richTextBox1.Text = content;
			}

			resizeTimer.Elapsed += new ElapsedEventHandler(resizeTimer_Elapsed);
			resizeTimer.Interval = 50;
		}

		private void resizeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.Invoke((MethodInvoker)(() => {
				Point curPos = this.PointToClient(Cursor.Position);

				int newWidth = curSize.Width + curPos.X - startPos.X;
				int newHeight = curSize.Height + curPos.Y - startPos.Y;

				this.Size = new Size(newWidth, newHeight);
			}));
		}

		public void SetColor(string colorStr)
		{
			this.colorStr = colorStr;
			if (colorStr == "yellow")
			{
				this.BackColor = Color.FromArgb(255, 231, 128);
				titlePanel.BackColor = Color.FromArgb(127, 115, 64);
				richTextBox1.ForeColor = Color.FromArgb(127, 115, 64);
				richTextBox1.BackColor = Color.FromArgb(255, 231, 128);
			}
		}

		public void Edit()
		{
			this.BringToFront();
			titleTextBox.Text = this.Text;
			modifiedTextBox.Text = dateModified.ToString();
			editPanel.Visible = true;
			ShowTitlebar(true);

			titleTextBox.Focus();
			titleTextBox.SelectionStart = richTextBox1.Text.Length;
			titleTextBox.SelectionLength = 0;
		}

		private void richTextBox1_TextChanged(object sender, System.EventArgs e)
		{
			dateModified = DateTime.Now;
			ContentChangedEventArgs args = new ContentChangedEventArgs()
			{
				Rtf = richTextBox1.Rtf,
				Text = richTextBox1.Text
			};
			OnContentChanged(args);
		}

		protected virtual void OnContentChanged(ContentChangedEventArgs e)
		{
			ContentChanged?.Invoke(this, e);
		}
		public event EventHandler<ContentChangedEventArgs> ContentChanged;

		protected virtual void OnTitleChanged(TitleChangedEventArgs e)
		{
			TitleChanged?.Invoke(this, e);
		}
		public event EventHandler<TitleChangedEventArgs> TitleChanged;

		private void saveBtn_Click(object sender, EventArgs e)
		{
			dateModified = DateTime.Now;
			editPanel.Visible = false;
			this.Text = titleTextBox.Text;
			TitleChangedEventArgs args = new TitleChangedEventArgs()
			{
				Title = titleTextBox.Text
			};
			OnTitleChanged(args);
		}

		private void NoteForm_Activated(object sender, EventArgs e)
		{
			ShowTitlebar(true);
			richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
			//richTextBox1.Height = this.Height - 82;
			resizeBtn.Visible = true;
		}

		private void NoteForm_Deactivate(object sender, EventArgs e)
		{
			ShowTitlebar(false);
			richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
			//richTextBox1.Height = this.Height - 52;
			resizeBtn.Visible = false;

			OnPerformSync(e);
		}

		private void titlePanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeAll;
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void NoteForm_TextChanged(object sender, EventArgs e)
		{
			titleLabel.Text = this.Text;
			secondTitleLabel.Text = this.Text;
		}

		private void titleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			this.titlePanel_MouseDown(sender, e);
		}

		private void NoteForm_Load(object sender, EventArgs e)
		{
			IntPtr nWinHandle = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
			nWinHandle = FindWindowEx(nWinHandle, IntPtr.Zero, "SHELLDLL_DefView", null);
			SetParent(Handle, nWinHandle);
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			if (editPanel.Visible)
			{
				editPanel.Visible = false;
			}
			else
			{
				Edit();
			}
		}

		private void ShowTitlebar(bool show)
		{
			if (show)
			{
				editBtn.Visible = true;
				closeBtn.Visible = true;
				newNoteBtn.Visible = true;

				titleLabel.Visible = true;
				titlePanel.Height = 30;

				secondTitleLabel.Visible = false;
			}
			else
			{
				if (!editPanel.Visible)
				{
					editBtn.Visible = false;
					closeBtn.Visible = false;
					newNoteBtn.Visible = false;

					titleLabel.Visible = false;
					titlePanel.Height = 8;

					secondTitleLabel.Visible = true;
				}
			}
		}

		private void titleTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				saveBtn.PerformClick();
			}
		}

		private void newNoteBtn_Click(object sender, EventArgs e)
		{
			PerformNewNoteEventArgs args = new PerformNewNoteEventArgs()
			{
				ColorStr = this.colorStr
			};
			OnPerformNewNote(args);
		}

		protected virtual void OnPerformNewNote(PerformNewNoteEventArgs e)
		{
			PerformNewNote?.Invoke(this, e);
		}
		public event EventHandler<PerformNewNoteEventArgs> PerformNewNote;

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			OnPerformDelete(e);
		}

		protected virtual void OnPerformDelete(EventArgs e)
		{
			PerformDelete?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> PerformDelete;

		protected virtual void OnPerformSync(EventArgs e)
		{
			PerformSync?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> PerformSync;

		private void SelectCurLine()
		{
			if (richTextBox1.SelectedText.Length == 0)
			{
				int firstCharIndex = richTextBox1.GetFirstCharIndexOfCurrentLine();
				int currentLine = richTextBox1.GetLineFromCharIndex(firstCharIndex);

				string currentLineText = richTextBox1.Lines[currentLine];
				richTextBox1.Select(firstCharIndex, currentLineText.Length);
			}
		}

		private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int firstCharIndex = richTextBox1.GetFirstCharIndexOfCurrentLine();
				int prevLine = richTextBox1.GetLineFromCharIndex(firstCharIndex) - 1;
				if (richTextBox1.Lines[prevLine].Length > 0)
				{
					if (richTextBox1.Lines[prevLine][0] == '○' || richTextBox1.Lines[prevLine][0] == '●')
					{
						richTextBox1.SelectedText = "○ ";
					}
				}
			}
		}

		private void NoteForm_MouseDown(object sender, MouseEventArgs e)
		{
			
			if (e.Button == MouseButtons.Left)
			{
				
			}
		}

		private void NoteForm_MouseUp(object sender, MouseEventArgs e)
		{
			
		}

		private void resizeBtn_MouseDown(object sender, MouseEventArgs e)
		{
			Console.WriteLine("md");
			Point downPos = this.PointToClient(Cursor.Position);
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeNWSE;
				startPos = downPos;
				curSize = this.Size;
				resizeTimer.Start();
			}
		}

		private void resizeBtn_MouseUp(object sender, MouseEventArgs e)
		{
			resizeTimer.Stop();
			Cursor.Current = Cursors.Default;
		}

		private void NoteForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.Shift)
				{
					if (e.KeyCode == Keys.E)
					{
						editBtn.PerformClick();
					}
				}
				else
				{
					if (e.KeyCode == Keys.N)
					{
						newNoteBtn.PerformClick();
					} 
					else if (e.KeyCode == Keys.Q)
					{
						closeBtn.PerformClick();
					}
				}
			}
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			try
			{
				if (richTextBox1.SelectionFont.Bold)
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
				}
				else
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
				}
			}
			catch
			{
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			try
			{
				if (richTextBox1.SelectionFont.Italic)
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
				}
				else
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
				}
			}
			catch
			{
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			try
			{
				if (richTextBox1.SelectionFont.Underline)
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
				}
				else
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
				}
			}
			catch
			{
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			try
			{
				if (richTextBox1.SelectionFont.Strikeout)
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
				}
				else
				{
					richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
				}
			}
			catch
			{
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void toggleBulletsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			//richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			if (richTextBox1.SelectedText[0] == '○')
			{
				richTextBox1.SelectedText = "●" + richTextBox1.SelectedText.Substring(1, richTextBox1.SelectedText.Length - 1);
			}
			else if (richTextBox1.SelectedText[0] == '●')
			{
				richTextBox1.SelectedText = "○" + richTextBox1.SelectedText.Substring(1, richTextBox1.SelectedText.Length - 1);
			}
			else
			{
				richTextBox1.SelectedText = "○ " + richTextBox1.SelectedText;
			}
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.SelectedText == richTextBox1.Text)
			{
				richTextBox1.DeselectAll();
			}
			else
			{
				richTextBox1.SelectAll();
			}
		}

		private void pasteAsPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste(DataFormats.GetFormat("Text"));
		}

		private void capitalizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			if (IsAllUpper(richTextBox1.SelectedText))
			{
				richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
			}
			else
			{
				richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
			}
		}

		private bool IsAllUpper(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (!Char.IsUpper(input[i]))
				{
					return false;
				}
			}
			return true;
		}

		private void superscriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			if (richTextBox1.SelectionCharOffset == 0)
			{
				richTextBox1.SelectionCharOffset = 4;
				richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 7, FontStyle.Regular);
			}
			else
			{
				richTextBox1.SelectionCharOffset = 0;
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void subscriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectCurLine();
			if (richTextBox1.SelectionCharOffset == 0)
			{
				richTextBox1.SelectionCharOffset = -1;
				richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 7, FontStyle.Regular);
			}
			else
			{
				richTextBox1.SelectionCharOffset = 0;
				richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
			}
		}

		private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}
	}

	public class ContentChangedEventArgs : EventArgs
	{
		public string Rtf { get; set; }
		public string Text { get; set; }
	}

	public class TitleChangedEventArgs : EventArgs
	{
		public string Title { get; set; }
	}

	public class PerformNewNoteEventArgs : EventArgs
	{
		public string ColorStr { get; set; }
	}
}
