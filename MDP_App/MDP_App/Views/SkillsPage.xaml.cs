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
    public partial class SkillsPage : ContentPage
    {
        public SkillsPage()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            granny.GestureRecognizers.Add(tap);
        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Статистика", "Посмотреть статистику игрока?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://worldoftanks.ru/ru/community/accounts/11286221-EviL_GrannY/", BrowserLaunchMode.SystemPreferred);
            }
        }
    }
}