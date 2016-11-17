using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using System.Linq;
using Android.Telephony;
using PhoneDial;
using PhoneDial.Droid;

[assembly: ExportRenderer(typeof(PhoneDialer), typeof(IDialer))]

namespace PhoneDial.Droid
{
	[Activity(Label = "PhoneDial.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
			Xamarin.Forms.DependencyService.Register<PhoneDialer>();
		}
	}

	public class LinkerPleaseInclude
	{
		public void Include(PhoneType injector) {
			injector = new PhoneType();
		}
	}

	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			var context = Forms.Context;
			if (context == null)
				return false;

			var uri = Android.Net.Uri.Parse("tel:" + number);
			var intent = new Intent(Intent.ActionDial, uri);

			if (IsIntentAvailable(context, intent))
			{
				context.StartActivity(intent);
				return true;
			}

			return false;
		}

		public static bool IsIntentAvailable(Context context, Intent intent)
		{

			var packageManager = context.PackageManager;

			var list = packageManager.QueryIntentServices(intent, 0)
				.Union(packageManager.QueryIntentActivities(intent, 0));
			if (list.Any())
				return true;

			TelephonyManager mgr = TelephonyManager.FromContext(context);
			return mgr.PhoneType != PhoneType.None;
		}
	}
}
