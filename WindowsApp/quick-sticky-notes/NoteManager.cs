using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace quick_sticky_notes
{
	public class NoteManager
	{
		private List<Note> notes = new List<Note>();
		private int noteCounter = 0;
		private string filePath = "QuickStickyNotes.json";

		public NoteManager()
		{

		}

		public void NewNote(string colorStr = "yellow")
		{
			Note note = new Note(noteCounter++);
			notes.Add(note);
			note.Show();
			note.SetColor(colorStr);

			NoteAddedEventArgs args = new NoteAddedEventArgs()
			{
				Note = note
			};
			OnNoteAdded(args);

			SaveToDisk();
		}

		public void RemoveNote(Note note)
		{
			note.Hide();
			notes.Remove(note);
		}

		public void SaveToDisk()
		{
			try
			{
				string text = "QuickStickyNotes-v1.0.0" + Environment.NewLine;
				text += noteCounter + Environment.NewLine;
				text += JsonConvert.SerializeObject(notes) + Environment.NewLine;
				File.WriteAllText(filePath, text);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void LoadFromDisk()
		{
			try
			{
				if (File.Exists(filePath))
				{
					string[] lines = File.ReadAllLines(filePath);
					if (lines.Length == 3)
					{
						int.TryParse(lines[1], out noteCounter);
						notes = JsonConvert.DeserializeObject<List<Note>>(lines[2]);
						for (int i = 0; i < notes.Count; i++)
						{
							NoteAddedEventArgs args = new NoteAddedEventArgs()
							{
								Note = notes[i]
							};
							OnNoteAdded(args);
						}
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
