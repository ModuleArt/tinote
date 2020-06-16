using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace quick_sticky_notes
{
	class FirebaseManager
	{
		private FirebaseApp firebaseApp;
		private FirebaseAuth firebaseAuth;

		private UserRecord userRecord;

		private LoginForm loginForm;

		public FirebaseManager()
		{

		}

		public async void Init()
		{
			firebaseApp = FirebaseApp.Create(new AppOptions()
			{
				Credential = GoogleCredential.FromFile("firebaseAdminCredentials.json")
			});

			firebaseAuth = FirebaseAuth.GetAuth(firebaseApp);
		}

		public bool IsLogin()
		{
			return false;
		}

		public void ShowLoginForm()
		{
			loginForm = new LoginForm();
			loginForm.Show();
			loginForm.PerformRegistration += LoginForm_PerformRegistration;
		}

		private async void LoginForm_PerformRegistration(object sender, PerformRegistrationEventArgs e)
		{
			userRecord = await firebaseAuth.CreateUserAsync(new UserRecordArgs
			{
				Email = e.Email,
				Password = e.Password
			});

			loginForm.Close();
			loginForm.Dispose();
		}
	}
}
