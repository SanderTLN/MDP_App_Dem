using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            amway.GestureRecognizers.Add(tap);
        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Статистика", "Посмотреть статистику игрока?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://worldoftanks.ru/ru/community/accounts/855119-Amway921/", BrowserLaunchMode.SystemPreferred);
            }
        }
    }
}