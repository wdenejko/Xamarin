using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Quotes
{
    public partial class MainView : ContentPage
    {
        private readonly List<string> _quotesList = new List<string>
        {
            "Terroryzm bazuje na pogardzie dla ludzkiego życia. Właśnie dlatego jest nie tylko motorem niewybaczalnych zbrodni, lecz on sam — używając terroru jako strategii politycznej i ekonomicznej — stanowi prawdziwe przestępstwo przeciw ludzkości.",
            "Nie zatwardzajmy serc, gdy słyszymy krzyk biednych. Starajmy się usłyszeć to wołanie. Starajmy się tak postępować i tak żyć, by nikomu w naszej Ojczyźnie nie brakło dachu nad głową i chleba na stole, by nikt nie czuł się samotny, pozostawiony bez opieki.",
            "Każde życie, nawet najmniej znaczące dla ludzi, ma wieczną wartość przed oczami Boga.",
            "Cywilizacja, która odrzuca bezbronnych, zasługuje na miano barbarzyńskiej.",
            "Dla chrześcijanina sytuacja nigdy nie jest beznadziejna."
        };

        private int _clickCounter = 1;

        public MainView()
        {
            InitializeComponent();
            Slider.Value = 18;
            QuoteLabel.Text = _quotesList.First();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            QuoteLabel.Text = _quotesList[_clickCounter%_quotesList.Count];
            _clickCounter++;
        }
    }
}
