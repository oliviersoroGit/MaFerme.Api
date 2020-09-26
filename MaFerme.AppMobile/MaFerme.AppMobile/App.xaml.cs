using MaFerme.AppMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaFerme.AppMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login()
            {
                //BackgroundColor = Color.White
            };
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
