using Xamarin.Forms;

namespace PhoneDial
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new PhoneDialPage();
			
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
