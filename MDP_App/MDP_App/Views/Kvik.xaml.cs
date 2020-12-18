﻿using System;
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
    public partial class Kvik : ContentPage
    {
        public Kvik()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            kvik.GestureRecognizers.Add(tap);

        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Глянь игрока!", "Посмотри данные о игроке, продолжить?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://wfts.su/profile/КвикСк0уп", BrowserLaunchMode.SystemPreferred);
            }
        }

    }
}