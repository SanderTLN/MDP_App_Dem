using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDP_App
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("wot.png"); //
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Павел Суханов",
                Detail = "Amway921",
                ImagePath = "amway.jpg",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Дмитрий Пановский",
                Detail = "EL COMENTANTE",
                ImagePath = "comentante.jpg",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Андрей Сомов",
                Detail = "EviL GrannY",
                ImagePath = "granny.jpg",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Константин Джов",
                Detail = "Jove",
                ImagePath = "jove.jpg",
                TargetPage = typeof(Views.AchievemnetsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Дмитрий Палащенко",
                Detail = "LeBwa",
                ImagePath = "lebwa.jpg",
                TargetPage = typeof(Views.Kvik)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Алексей Кучкин",
                Detail = "Near_You",
                ImagePath = "near.png",
                TargetPage = typeof(Views.Cloud)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Кира Краснова",
                Detail = "TR1SS",
                ImagePath = "triss.jpg",
                TargetPage = typeof(Views.Silveon)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        } 
    }
}
