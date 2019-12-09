using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RaceMe.Views;

namespace RaceMe
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new LoginPage());

            //
            //By Passes Login taking straight to Main Page
            //
            MainPage mainPage = new MainPage();
            mainPage.Detail = new NavigationPage(new RoutesLogPage());
            App.Current.MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // This is a change.
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
