using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FirstFormsApp
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            Slider.Value = 0.5;

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0), 
            //    Android: new Thickness(10,20,0,0),
            //    WinPhone: new Thickness(30,20,0,0) 
            //);

            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}, Android: () =>
            //{
            //     ....
            //});
        }
        
    }
}
