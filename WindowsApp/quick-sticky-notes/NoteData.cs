namespace quick_sticky_notes
{
	public class NoteData
	{
		public string i { get; set; } // unique note id
		public string u { get; set; } // user email
		public string l { get; set; } // note title
		public string t { get; set; } // note text
		public string s { get; set; } // sync date
		public string d { get; set; } // date created
		public string c { get; set; } // note color
		public string[] a { get; set; } // attachments
	}
}