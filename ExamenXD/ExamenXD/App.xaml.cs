using System;
using ExamenXD.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenXD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vistaxd();
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
