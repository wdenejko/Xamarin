using System;
using Xamarin.Forms;

namespace PhoneDial
{
	public partial class PhoneDialPage : ContentPage
	{
		public PhoneDialPage()
		{
			InitializeComponent();
			NumberLabel.Text = string.Empty;
		}

		void Click(object sender, System.EventArgs e)
		{
			NumberLabel.Text += ((Button)sender).Text;
		}

		public async void OnPhoneTapped(object sender, EventArgs e)
		{
			if (await this.DisplayAlert(
							 "Dial a Number",
				"Call " + NumberLabel.Text + "?",
							 "Yes",
							 "No"))
			{
				var dialer = DependencyService.Get<IDialer>();
				if (dialer != null)
				{
					dialer.Dial(NumberLabel.Text);
					NumberLabel.Text = string.Empty;
				}
			}
		}
	}
}
