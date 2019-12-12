using System;
using Xamarin.Forms;
using ExpenseApp.Views;
using Xamarin.Forms.Xaml;

namespace ExpenseApp
{
    public partial class App : Application
    {
        public static string DatabasePath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string databasePath)
        {
            InitializeComponent();

            DatabasePath = databasePath;

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
