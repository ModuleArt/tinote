using Firebase.Auth;
using Firebase.Database;
using System;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace quick_sticky_notes
{
	public class FirebaseManager
	{
		private FirebaseAuthProvider firebaseAuth;
		private FirebaseClient firebaseClient;

		private LoginForm loginForm;
		private ProfileForm profileForm;

		private User curUser;

		public FirebaseManager()
		{
			firebaseAuth = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCg49vr3LJSA1hm8tV7434fuOw2qDWyeA0"));
			firebaseClient = new FirebaseClient("https://quickstart-1591709762723.firebaseio.com/");
		}

		public bool IsLoggedIn()
		{
			return curUser != null;
		}

		public void ShowProfileForm()
		{
			if (profileForm == null || profileForm.IsDisposed)
			{
				profileForm = new ProfileForm(curUser.DisplayName, curUser.Email);
				profileForm.Show();

				profileForm.PerformSignOut += ProfileForm_PerformSignOut;
			}
		}

		private void ProfileForm_PerformSignOut(object sender, EventArgs e)
		{
			SignOut();
		}

		public void ShowLoginForm()
		{
			if (loginForm == null || loginForm.IsDisposed)
			{
				loginForm = new LoginForm();
				loginForm.Show();

				loginForm.PerformRegistration += LoginForm_PerformRegistration1;
				loginForm.PerformLogin += LoginForm_PerformLogin1;
			}
		}

		private void LoginForm_PerformLogin1(object sender, PerformLoginEventArgs e)
		{
			Login(e.Email, e.Password);
		}

		private void LoginForm_PerformRegistration1(object sender, PerformRegistrationEventArgs e)
		{
			Register(e.DisplayName, e.Email, e.Password);
		}

		private void SignOut()
		{
			curUser = null;
			SaveUserToDisk();
			OnSignStatusChanged(EventArgs.Empty);

			profileForm.Close();
			profileForm.Dispose();
		}

		private async void Register(string displayName, string email, string password)
		{
			FirebaseAuthLink fal = await firebaseAuth.CreateUserWithEmailAndPasswordAsync(email, password, displayName);
			curUser = fal.User;
			SaveUserToDisk();
			OnSignStatusChanged(EventArgs.Empty);

			loginForm.Close();
			loginForm.Dispose();

			ShowProfileForm();
		}

		private async void Login(string email, string password)
		{
			FirebaseAuthLink fal = await firebaseAuth.SignInWithEmailAndPasswordAsync(email, password);
			curUser = fal.User;
			SaveUserToDisk();
			OnSignStatusChanged(EventArgs.Empty);

			loginForm.Close();
			loginForm.Dispose();

			ShowProfileForm();
		}

		public void AddObserversForServer()
		{
			try
			{
				var observable = firebaseClient.Child("notes").OrderByValue().StartAt(curUser.Email).AsObservable<NoteData>().Subscribe(item =>
				{
					UpdateNoteEventArgs args = new UpdateNoteEventArgs
					{
						Data = item.Object
					};
					OnUpdateNote(args);
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public async void SyncNote(Note note)
		{
			try
			{
				var data = new NoteData
				{
					i = note.uniqueId,
					u = curUser.Email,
					l = note.title,
					t = note.contentRtf,
					s = DateTime.Now.ToBinary().ToString(),
					c = note.colorStr,
					d = note.dateCreated.ToBinary().ToString()
				};

				await firebaseClient.Child("notes").Child(note.uniqueId.ToString()).PutAsync<NoteData>(data);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public async void RemoveNote(string uniqueId)
		{
			try
			{
				await firebaseClient.Child("notes").Child(uniqueId).DeleteAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public string GenerateUniqueID()
		{
			Random r = new Random();
			string res;

			if (IsLoggedIn())
			{
				res = curUser.Email.Replace('@', '-').Replace('.', '-');
			}
			else
			{
				res = "unknown" + r.Next(0, int.MaxValue).ToString();
			}

			res += "_" + DateTime.Now.ToBinary();
			res += "_" + r.Next(int.MinValue, int.MaxValue).ToString();

			return res;
		}

		public void SaveUserToDisk()
		{
			try
			{
				string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote");
				DirectoryInfo di = new DirectoryInfo(appDataFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				string curUserPath = Path.Combine(appDataFolder, "curuser.json");

				if (curUser == null)
				{
					if (File.Exists(curUserPath))
					{
						File.Delete(curUserPath);
					}
				}
				else
				{
					string text = JsonConvert.SerializeObject(curUser);
					File.WriteAllText(curUserPath, text);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void LoadUserFromDisk()
		{
			try
			{
				string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tinote");
				DirectoryInfo di = new DirectoryInfo(appDataFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				string curUserPath = Path.Combine(appDataFolder, "curuser.json");

				if (File.Exists(curUserPath))
				{
					string[] lines = File.ReadAllLines(curUserPath);
					if (lines.Length >= 1)
					{
						curUser = JsonConvert.DeserializeObject<User>(lines[0]);
						OnSignStatusChanged(EventArgs.Empty);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public async void LoadNotesFromServer()
		{
			try
			{
				var notes = await firebaseClient.Child("notes").OrderByValue().StartAt(curUser.Email).OnceAsync<NoteData>();

				if (notes.Count > 0)
				{
					foreach (var item in notes)
					{
						UpdateNoteEventArgs args = new UpdateNoteEventArgs
						{
							Data = item.Object
						};
						OnUpdateNote(args);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		protected virtual void OnUpdateNote(UpdateNoteEventArgs e)
		{
			UpdateNote?.Invoke(this, e);
		}
		public event EventHandler<UpdateNoteEventArgs> UpdateNote;

		protected virtual void OnSignStatusChanged(EventArgs e)
		{
			SignStatusChanged?.Invoke(this, e);
		}
		public event EventHandler<EventArgs> SignStatusChanged;
	}

	public class UpdateNoteEventArgs : EventArgs
	{
		public NoteData Data { get; set; }
	}
}
