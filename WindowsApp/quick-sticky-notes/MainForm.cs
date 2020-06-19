using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace quick_sticky_notes
{
	public partial class MainForm : Form
	{
        private FirebaseApp firebaseApp;
        private FirebaseAuth firebaseAuth;

        private NoteManager noteManager;
        //private GSyncManager gSyncManager;
        private bool quitApp = false;

        public MainForm()
		{
			InitializeComponent();

            noteManager = new NoteManager();
            noteManager.NoteAdded += NoteManager_NoteAdded;

            //gSyncManager = new GSyncManager();
            //gSyncManager.SyncDone += GSyncManager_SyncDone;
            //gSyncManager.Authorize();

            FirebaseManager fm = new FirebaseManager();
            fm.Init();
        }

        private void NoteManager_NoteAdded(object sender, NoteAddedEventArgs e)
        {
            notesListBox.Items.Add(e.Note);
            e.Note.ContentChanged += Note_ContentChanged;
            e.Note.TitleChanged += Note_TitleChanged;
            e.Note.VisibleChanged += Note_VisibleChanged;
            e.Note.PositionChanged += Note_PositionChanged;
            e.Note.PerformNewNote += Note_PerformNewNote;
            e.Note.PerformDelete += Note_PerformDelete;
            e.Note.PerformSync += Note_PerformSync;
            e.Note.ShowNotesList += Note_ShowNotesList;
            e.Note.ColorChanged += Note_ColorChanged;

            if (e.Note.visible)
            {
                e.Note.Show();
            }
        }

        private void Note_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            noteManager.SaveToDisk();
        }

        private void Note_ShowNotesList(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Note_PerformSync(object sender, EventArgs e)
        {
            //gSyncManager.Upload();
        }

        private void Note_PerformDelete(object sender, EventArgs e)
        {
            noteManager.RemoveNote(sender as Note);
            notesListBox.Items.Remove(sender as Note);
            noteManager.SaveToDisk();
        }

        private void Note_PerformNewNote(object sender, PerformNewNoteEventArgs e)
        {
            noteManager.NewNote();
        }

        private void Note_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            noteManager.SaveToDisk();
        }

        private void Note_VisibleChanged(object sender, VisibleChangedEventArgs e)
        {
            notesListBox.Refresh();
            noteManager.SaveToDisk();
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            noteManager.NewNote();
        }

        private void Note_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            for (int i = 0; i < notesListBox.Items.Count; i++)
            {
                if (notesListBox.Items[i] as Note == sender)
                {
                    notesListBox.Items[i] = sender;
                }
            }
            noteManager.SaveToDisk();
        }

        private void Note_ContentChanged(object sender, ContentChangedEventArgs e)
        {
            for (int i = 0; i < notesListBox.Items.Count; i++)
            {
                if (notesListBox.Items[i] as Note == sender)
                {
                    notesListBox.Items[i] = sender;
                }
            }
            noteManager.SaveToDisk();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void notesListBox_DoubleClick_1(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                if (note.visible)
                {
                    note.Focus();
                }
                else
                {
                    note.Show();
                }
            }
        }

        private void notesListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = notesListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    notesListBox.SelectedIndex = index;
                    notesListItemContext.Show(Cursor.Position);
                }
                else
                {
                    notesListEmptyContext.Show(Cursor.Position);
                }
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.Show();
                note.Edit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            noteManager.LoadFromDisk();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                noteManager.RemoveNote(notesListBox.SelectedItem as Note);
                notesListBox.Items.Remove(notesListBox.SelectedItem as Note);
                noteManager.SaveToDisk();
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quitApp)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitApp = true;
            this.Close();
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.SizeAll;
                ShellManager.ReleaseCapture();
                ShellManager.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.titlePanel_MouseDown(sender, e);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.Show();
            }
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote();
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search your notes...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Search your notes...";
                searchTextBox.ForeColor = Color.FromArgb(100, 100, 100);
            }   
        }

        private void notesListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                Note note = notesListBox.Items[e.Index] as Note;

                Brush darkBrush = new SolidBrush(ColorManager.GetDarkColor(note.colorStr));
                Brush middleBrush = new SolidBrush(ColorManager.GetMiddleColor(note.colorStr));
                Brush noteBrush = new SolidBrush(ColorManager.GetNoteColor(note.colorStr));
                Brush backBrush = new SolidBrush(this.BackColor);

                e.Graphics.FillRectangle(darkBrush, new RectangleF(
                    e.Bounds.X + 9,
                    e.Bounds.Y + 9,
                    e.Bounds.Width - 18,
                    8
                ));
                e.Graphics.FillRectangle(noteBrush, new RectangleF(
                    e.Bounds.X + 9, 
                    e.Bounds.Y + 17,
                    e.Bounds.Width - 18,
                    e.Bounds.Height - 17
                ));

                e.Graphics.DrawString(note.title, e.Font, darkBrush, e.Bounds.X + 16, e.Bounds.Y + 21);
                e.Graphics.DrawString(Regex.Replace(note.contentText, @"\t|\n|\r", " "), e.Font, middleBrush, e.Bounds.X + 16, e.Bounds.Y + 39);

                e.Graphics.FillRectangle(backBrush, new RectangleF(
                    e.Bounds.X + e.Bounds.Width - 9,
                    e.Bounds.Y,
                    9,
                    e.Bounds.Height
                ));

                // right side gradient
                var rc = new Rectangle(
                    e.Bounds.X + e.Bounds.Width - 39,
                    e.Bounds.Y + 17, 
                    20,
                    e.Bounds.Height - 17
                );
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    rc,
                    Color.FromArgb(0, ColorManager.GetNoteColor(note.colorStr)),
                    Color.FromArgb(255, ColorManager.GetNoteColor(note.colorStr)),
                    0f
                )) {
                    e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                    e.Graphics.FillRectangle(brush, rc);
                }

                e.Graphics.FillRectangle(noteBrush, new RectangleF(
                    e.Bounds.X + e.Bounds.Width - 21,
                    e.Bounds.Y + 17,
                    12,
                    e.Bounds.Height - 17
                ));

                // bottom right corner
                if (note.visible)
                {
                    PointF[] outerNoteTriangle =
                    {
                         new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height - 12),
                         new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height),
                         new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height)
                    };
                    e.Graphics.FillPolygon(backBrush, outerNoteTriangle);

                    PointF[] innerNoteTriangle =
                    {
                         new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height - 12),
                         new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height),
                         new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height - 12)
                    };
                    e.Graphics.FillPolygon(middleBrush, innerNoteTriangle);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
            {
                

                for (int i = 0; i < notesListBox.Items.Count; i++)
                {
                    if (notesListBox.Items[i].ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        //notesListBox.Items[i]
                    }
                    else
                    {

                    }
                }
            } 
            else
            {

            }
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.black_close;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.white_close;
        }
    }
}
