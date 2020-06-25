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
            m_aeroEnabled = true;
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
            //syncBtn.Visible = fm.IsLoggedIn();
        }

        private void Fm_UpdateNote(object sender, UpdateNoteEventArgs e)
        {
            noteManager.UpdateNote(e.Data);
            notesListBox.Invalidate();
        }

        private void NoteManager_NoteAdded(object sender, NoteAddedEventArgs e)
        {
            notesListBox.Invoke((MethodInvoker)(() => {
                notesListBox.Items.Add(e.Note);
            }));

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
            Note note = sender as Note;

            if (notesListBox.Items.Contains(note))
            {
                notesListBox.Items.Remove(note);
            }

            fm.RemoveNote(note.uniqueId);
            noteManager.RemoveNote(note);
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
                //fm.LoadNotesFromServer();

                fm.AddObserversForServer();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;

                if (notesListBox.Items.Contains(note))
                {
                    notesListBox.Items.Remove(note);
                }

                fm.RemoveNote(note.uniqueId);
                noteManager.RemoveNote(note);
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
                Brush backBrush = new SolidBrush(notesListBox.BackColor);

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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.P)
                    {
                        profileBtn.PerformClick();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.N)
                    {
                        newNoteBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.A)
                    {
                        allNotesBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.T)
                    {
                        trashBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.P)
                    {
                        pinnedNotesBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.F)
                    {
                        searchTextBox.Focus();
                    }
                    else if (e.KeyCode == Keys.Oemcomma)
                    {
                        settingsBtn.Focus();
                    }
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

            titlePanel.BackColor = Color.FromArgb(227, 227, 225);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; 
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            titlePanel.BackColor = Color.FromArgb(214, 213, 210);
        }
    }
}
