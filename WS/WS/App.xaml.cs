using System;
using WS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WS
{
    public partial class App : Application
    {
        public static string dBpath;
        public static string dBname;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PagePrincipal());
        }
        public App(string dbPath, string dbName)
        {
            InitializeComponent();
            App.dBpath = dbPath; 
            App.dBname = dbName;
            MainPage = new NavigationPage(new PagePrincipal());
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
