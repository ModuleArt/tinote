using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace quick_sticky_notes
{
	class FirebaseManager
	{
		private FirebaseApp firebaseApp;
		private FirebaseAuth firebaseAuth;

		private LoginForm loginForm;

		public FirebaseManager()
		{

		}

		public async void Authorize()
		{
			firebaseApp = FirebaseApp.Create(new AppOptions()
			{
				Credential = GoogleCredential.FromFile("firebaseAdminCredentials.json")
			});

			firebaseAuth = FirebaseAuth.GetAuth(firebaseApp);

			//List<UserIdentifier> users = new List<UserIdentifier>();
			//users.Add("vkxYnftsTQa2NxDggPNKhKzQemI2" as UserIdentifier);

			//ReadOnlyCollection<UserIdentifier> readOnlyDinosaurs = new ReadOnlyCollection<UserIdentifier>(users);

			//IReadOnlyCollection<UserIdentifier> irocUsers = new List<UserIdentifier>(1);
			//var x = await firebaseAuth.GetUsersAsync(irocUsers);

			//Console.WriteLine();

			

			//var x = await firebaseAuth.CreateUserAsync(new UserRecordArgs { 
			//	Email = "aaaaaa@gmail.com", 
			//	Password = "aaaaaa" 
			//});
		}

		public void ShowLoginForm()
		{
			loginForm = new LoginForm();
			loginForm.Show();
			loginForm.PerformRegistration += LoginForm_PerformRegistration;
		}

		private async void LoginForm_PerformRegistration(object sender, PerformRegistrationEventArgs e)
		{
			var x = await firebaseAuth.CreateUserAsync(new UserRecordArgs
			{
				Email = e.Email,
				Password = e.Password
			});
		}
	}
}
