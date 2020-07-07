using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace quick_sticky_notes
{
	public class NoteManager
	{
		private List<Note> notes = new List<Note>();
		public string trashFolderId = "$";
		public string noFolderId = "";
		public string currentFolder;

		public NoteManager()
		{
			currentFolder = noFolderId;
		}

		public List<Note> SearchFor(string str = "")
		{
			if (string.IsNullOrEmpty(str))
			{
				List<Note> res = new List<Note>();

				for (int i = 0; i < notes.Count; i++)
				{
					if (notes[i].folderName == currentFolder)
					{
						res.Add(notes[i]);
					}
				}

				return res;
			}
			else
			{
				List<Note> res = new List<Note>();

				for (int i = 0; i < notes.Count; i++)
				{
					if (notes[i].ToString().ToLower().Contains(str.ToLower()))
					{
						res.Add(notes[i]);
					}
				}

				return res;
			}
		}

		public void NewNote(string uniqueId, string colorStr = "yellow")
		{
			Note note = new Note(uniqueId, colorStr, DateTime.Now);
			notes.Add(note);
			note.Show();

			NoteAddedEventArgs args = new NoteAddedEventArgs()
			{
				Note = note
			};
			OnNoteAdded(args);

			SaveNoteToDisk(note);
		}

		public void RemoveNote(Note note)
		{
			string notesFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote", "notes");
			DirectoryInfo di = new DirectoryInfo(notesFolder);

			if (!di.Exists)
			{
				di.Create();
			}

			string uniqueId = note.uniqueId;
			string filePath = Path.Combine(notesFolder, uniqueId);

			note.deleted = true;
			note.Hide();
			notes.Remove(note);
		}

		public void SaveNoteToDisk(Note note)
		{
			try
			{
				string notesFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote", "notes");
				DirectoryInfo di = new DirectoryInfo(notesFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				File.WriteAllText(Path.Combine(notesFolder, note.uniqueId), JsonConvert.SerializeObject(note));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void UpdateNote(NoteData data)
		{
			bool noteExists = false;
			for (int i = 0; i < notes.Count; i++)
			{
				if (notes[i].uniqueId == data.i)
				{
					notes[i].SetTitle(data.l);
					notes[i].SetColor(data.c);
					notes[i].SetContent(data.t);
					notes[i].ChangeFolder(data.f);

					DateTime dt = DateTime.FromBinary(long.Parse(data.s));
					notes[i].SetSyncDate(dt);

					SaveNoteToDisk(notes[i]);

					noteExists = true;
				}
			}

			if (!noteExists)
			{
				string notePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote", "notes", data.i);

				if (!File.Exists(notePath))
				{
					Note note = new Note(data.i, data.c, DateTime.FromBinary(long.Parse(data.d)));
					note.SetContent(data.t);
					note.SetTitle(data.l);

					notes.Add(note);

					NoteAddedEventArgs args = new NoteAddedEventArgs()
					{
						Note = note
					};
					OnNoteAdded(args);

					SaveNoteToDisk(note);
				}
			}
		}

		public void LoadNotesFromDisk()
		{
			try
			{
				string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote", "notes");
				DirectoryInfo di = new DirectoryInfo(appDataFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				string[] filePaths = Directory.GetFiles(appDataFolder);

				notes = new List<Note>();

				for (int i = 0; i < filePaths.Length; i++)
				{
					string[] lines = File.ReadAllLines(filePaths[i]);
					Note note = JsonConvert.DeserializeObject<Note>(lines[0]);

					if (!note.deleted)
					{
						notes.Add(note);

						NoteAddedEventArgs args = new NoteAddedEventArgs()
						{
							Note = note
						};
						OnNoteAdded(args);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		protected virtual void OnNoteAdded(NoteAddedEventArgs e)
		{
			NoteAdded?.Invoke(this, e);
		}
		public event EventHandler<NoteAddedEventArgs> NoteAdded;
	}

	public class NoteAddedEventArgs : EventArgs
	{
		public Note Note { get; set; }
	}
}
