using System;
using SillyList.View;
using SillyList.Model;
using SillyList.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SillyList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
