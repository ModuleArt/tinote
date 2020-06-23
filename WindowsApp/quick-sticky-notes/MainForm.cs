using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class MainForm : Form
	{
        private FirebaseManager fm;
        private NoteManager noteManager;
        private bool quitApp = false;

        public MainForm()
		{
			InitializeComponent();

            noteManager = new NoteManager();
            noteManager.NoteAdded += NoteManager_NoteAdded;

            fm = new FirebaseManager();
            fm.UpdateNote += Fm_UpdateNote;
            fm.SignStatusChanged += Fm_SignStatusChanged;
            fm.LoadUserFromDisk();
        }

        private void Fm_SignStatusChanged(object sender, EventArgs e)
        {
            syncBtn.Visible = fm.IsLoggedIn();
        }

        private void Fm_UpdateNote(object sender, UpdateNoteEventArgs e)
        {
            noteManager.UpdateNote(e.Data);
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
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_ShowNotesList(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void Note_PerformSync(object sender, EventArgs e)
        {
            if (fm.IsLoggedIn())
            {
                fm.SyncNote(sender as Note);
            }
        }

        private void Note_PerformDelete(object sender, EventArgs e)
        {
            noteManager.RemoveNote(sender as Note);
            notesListBox.Items.Remove(sender as Note);
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_PerformNewNote(object sender, PerformNewNoteEventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void Note_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_VisibleChanged(object sender, VisibleChangedEventArgs e)
        {
            notesListBox.Invalidate();
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
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
            noteManager.SaveNoteToDisk(sender as Note);
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
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (fm.IsLoggedIn())
            {
                fm.ShowProfileForm();
            }
            else
            {
                fm.ShowLoginForm();
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            noteManager.LoadNotesFromDisk();
            
            if (fm.IsLoggedIn())
            {
                fm.LoadNotesFromServer();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                noteManager.RemoveNote(notesListBox.SelectedItem as Note);
                notesListBox.Items.Remove(notesListBox.SelectedItem as Note);
                noteManager.SaveNoteToDisk(sender as Note);
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
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
            this.BringToFront();
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
                this.BringToFront();
            }
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.SizeAll;
                NativeMethodsManager.ReleaseCapture();
                NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
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

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = Color.Black;
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.Text = "Search your notes...";
            searchTextBox.ForeColor = Color.FromArgb(100, 100, 100);
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
                ))
                {
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
            if (searchTextBox.Text.Length > 0 && searchTextBox.Text != "Search your notes...")
            {
                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor(searchTextBox.Text);
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }
            }
            else
            {
                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor();
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }
            }

            emptyLabel.Visible = notesListBox.Items.Count == 0;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.black_close;
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.white_close;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    newNoteBtn.PerformClick();
                }
                else if (e.KeyCode == Keys.D)
                {
                    syncBtn.PerformClick();
                }
                else if (e.KeyCode == Keys.Q)
                {
                    closeBtn.PerformClick();
                }
                else if (e.KeyCode == Keys.P)
                {
                    profileBtn.PerformClick();
                }
                else if (e.KeyCode == Keys.F)
                {
                    searchTextBox.Focus();
                }
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                notesListBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm.LoadNotesFromServer();
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("yellow");
                notesListBox.Invalidate();
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("green");
                notesListBox.Invalidate();
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("blue");
                notesListBox.Invalidate();
            }
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("pink");
                notesListBox.Invalidate();
            }
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("purple");
                notesListBox.Invalidate();
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("white");
                notesListBox.Invalidate();
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            notesListBox.Focus();
        }
    }
}
