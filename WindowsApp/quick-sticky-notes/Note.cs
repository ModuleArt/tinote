using System;

namespace quick_sticky_notes
{
	public class Note
	{
		public string uniqueId;
		public string title = "New note";
		public string contentRtf = "Take a note...";
		public string contentText = "Take a note...";
		public bool visible = false;
		public DateTime dateCreated;
		public int x = -1;
		public int y = -1;
		public int width = -1;
		public int height = -1;
		public string colorStr = "yellow";
		private NoteForm noteForm;

		public Note(string uniqueId, string colorStr)
		{
			this.uniqueId = uniqueId;
			this.colorStr = colorStr;
			this.dateCreated = DateTime.Now;
		}

		public void SetTitle(string title)
		{
			if (title != this.title)
			{
				this.title = title;
				if (noteForm != null && !noteForm.IsDisposed)
				{
					noteForm.SetTitle(title);
				}
			}
		}

		public void SetContent(string rtf)
		{
			if (rtf != this.contentRtf)
			{
				this.contentRtf = rtf;
				if (noteForm != null && !noteForm.IsDisposed)
				{
					noteForm.SetContent(rtf);
				}
			}	
		}

		public void SetColor(string colorStr)
		{
			if (colorStr != this.colorStr)
			{
				this.colorStr = colorStr;
				if (noteForm != null && !noteForm.IsDisposed)
				{
					noteForm.SetColor(colorStr);
				}
			}
		}

		public void Focus()
		{
			noteForm.Focus();
		}

		public void Show()
		{
			if (noteForm == null || noteForm.IsDisposed)
			{
				noteForm = new NoteForm(title, contentRtf, colorStr, dateCreated);
				noteForm.ContentChanged += NoteForm_ContentChanged;
				noteForm.TitleChanged += NoteForm_TitleChanged;
				noteForm.FormClosing += NoteForm_FormClosing;
				noteForm.ResizeEnd += NoteForm_ResizeEnd;
				noteForm.PerformNewNote += NoteForm_PerformNewNote;
				noteForm.PerformDelete += NoteForm_PerformDelete;
				noteForm.PerformSync += NoteForm_PerformSync;
				noteForm.ShowNotesList += NoteForm_ShowNotesList;
				noteForm.ColorChanged += NoteForm_ColorChanged;
			}

			visible = true;
			VisibleChangedEventArgs args = new VisibleChangedEventArgs()
			{
				Visible = visible
			};
			OnVisibleChanged(args);

			noteForm.Show();
			if (y != -1)
			{
				noteForm.Location = new System.Drawing.Point(x, y);
			}
			if (width != -1)
			{
				noteForm.Size = new System.Drawing.Size(width, height);
			}
		}

		private void NoteForm_ColorChanged(object sender, ColorChangedEventArgs e)
		{
			this.colorStr = e.ColorStr;

			ColorChangedEventArgs args = new ColorChangedEventArgs()
			{
				ColorStr = e.ColorStr
			};
			OnColorChanged(args);
		}

		private void NoteForm_ShowNotesList(object sender, EventArgs e)
		{
			OnShowNotesList(e);
		}

		private void NoteForm_PerformSync(object sender, EventArgs e)
		{
			OnPerformSync(e);
		}

		private void NoteForm_PerformDelete(object sender, EventArgs e)
		{
			OnPerformDelete(e);
		}

		private void NoteForm_PerformNewNote(object sender, PerformNewNoteEventArgs e)
		{
			PerformNewNoteEventArgs args = new PerformNewNoteEventArgs()
			{
				ColorStr = e.ColorStr
			};
			OnPerformNewNote(args);
		}

		private void NoteForm_ResizeEnd(object sender, EventArgs e)
		{
			x = noteForm.Location.X;
			y = noteForm.Location.Y;
			width = noteForm.Width;
			height = noteForm.Height;
			PositionChangedEventArgs args = new PositionChangedEventArgs()
			{
				X = x,
				Y = y,
				Width = width,
				Height = height
			};
			OnPositionChanged(args);
		}

		private void NoteForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			visible = false;
			VisibleChangedEventArgs args = new VisibleChangedEventArgs()
			{
				Visible = visible
			};
			OnVisibleChanged(args);
			noteForm.Dispose();
		}

		public void Hide()
		{
			VisibleChangedEventArgs args = new VisibleChangedEventArgs()
			{
				Visible = visible
			};
			OnVisibleChanged(args);

			visible = false;
			if (noteForm != null && !noteForm.IsDisposed)
			{
				noteForm.Dispose();
			}
		}

		private void NoteForm_TitleChanged(object sender, TitleChangedEventArgs e)
		{
			title = e.Title;
			TitleChangedEventArgs args = new TitleChangedEventArgs()
			{
				Title = title
			};
			OnTitleChanged(args);
		}

		private void NoteForm_ContentChanged(object sender, ContentChangedEventArgs e)
		{
			this.contentText = e.Text;
			this.contentRtf = e.Rtf;
			ContentChangedEventArgs args = new ContentChangedEventArgs()
			{
				Rtf = e.Rtf,
				Text = e.Text
			};
			OnContentChanged(args);
		}

		public override string ToString()
		{
			if (contentText.Length > 0)
			{
				return title + " " + contentText;
			}
			else
			{
				return title;
			}
		}

		public void Edit()
		{
			noteForm.Edit();
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

		protected virtual void OnVisibleChanged(VisibleChangedEventArgs e)
		{
			VisibleChanged?.Invoke(this, e);
		}
		public event EventHandler<VisibleChangedEventArgs> VisibleChanged;

		protected virtual void OnPositionChanged(PositionChangedEventArgs e)
		{
			PositionChanged?.Invoke(this, e);
		}
		public event EventHandler<PositionChangedEventArgs> PositionChanged;

		protected virtual void OnPerformNewNote(PerformNewNoteEventArgs e)
		{
			PerformNewNote?.Invoke(this, e);
		}
		public event EventHandler<PerformNewNoteEventArgs> PerformNewNote;

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

		protected virtual void OnShowNotesList(EventArgs e)
		{
			ShowNotesList?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> ShowNotesList;

		protected virtual void OnColorChanged(ColorChangedEventArgs e)
		{
			ColorChanged?.Invoke(this, e);
		}
		public event EventHandler<ColorChangedEventArgs> ColorChanged;
	}

	public class VisibleChangedEventArgs : EventArgs
	{
		public bool Visible { get; set; }
	}

	public class PositionChangedEventArgs : EventArgs
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
	}
}
