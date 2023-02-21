using PM2E1786519.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E1786519
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageMapa();
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
