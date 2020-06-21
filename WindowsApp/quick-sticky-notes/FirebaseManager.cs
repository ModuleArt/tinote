using Firebase.Auth;
using Firebase.Database;
using System;
using Firebase.Database.Query;

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

				profileForm.PerformSync += ProfileForm_PerformSync;
				profileForm.PerformSignOut += ProfileForm_PerformSignOut;
			}
		}

		private void ProfileForm_PerformSignOut(object sender, EventArgs e)
		{
			SignOut();
		}

		private void ProfileForm_PerformSync(object sender, EventArgs e)
		{
			Sync(0, "text 2");
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

			profileForm.Close();
			profileForm.Dispose();
		}

		private async void Register(string displayName, string email, string password)
		{
			FirebaseAuthLink fal = await firebaseAuth.CreateUserWithEmailAndPasswordAsync(email, password, displayName);
			curUser = fal.User;


			loginForm.Close();
			loginForm.Dispose();

			ShowProfileForm();
		}

		private async void Login(string email, string password)
		{
			FirebaseAuthLink fal = await firebaseAuth.SignInWithEmailAndPasswordAsync(email, password);
			curUser = fal.User;

			loginForm.Close();
			loginForm.Dispose();

			ShowProfileForm();
		}

		public async void Sync(int noteId, string noteText)
		{
			var data = new Data
			{
				u = curUser.Email,
				t = noteText,
				d = DateTime.Now.ToString()
			};

			//var response = await firebaseClient.Child(noteId.ToString()).OnceAsync<Data>();
			
			//if (response.Count > 0)
			//{
				await firebaseClient.Child(noteId.ToString()).PutAsync<Data>(data);
			//}
			//else
			//{
			//	var responce2 = await firebaseClient.Child(noteId.ToString()).PostAsync(data);
			//}

			//SetResponse response = await ifclient.SetAsync("notes/note-1", data);
			//Data result = response.ResultAs<Data>();
		}
	}

	internal class Data
	{
		public string u { get; set; }
		public string t { get; set; }
		public string d { get; set; }
		public string[] a { get; set; }
	}
}
