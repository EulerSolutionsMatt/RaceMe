using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaceMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private void btnMyRoutes_Clicked(object sender, MR.Gestures.DownUpEventArgs e)
        {
            //TODO navigate user to RoutesLogPage
            btnMyRoutes.BackgroundColor = Color.FromHex("#6caefa");


        }
        private void btnMyRoutes_Released(object sender, MR.Gestures.DownUpEventArgs e)
        {
            
            btnMyRoutes.BackgroundColor = Color.FromHex("#2196F3");

        }
        private void btnNewRoute_Clicked(object sender, MR.Gestures.DownUpEventArgs e)
        {
            //TODO Navigate user to NewRoutePage
            btnNewRoute.BackgroundColor = Color.FromHex("#6caefa");
        }
        private void btnNewRoute_Released(object sender, MR.Gestures.DownUpEventArgs e)
        {
            
            btnNewRoute.BackgroundColor = Color.FromHex("#2196F3");
        }
        private void btnSettings_Clicked(object sender, MR.Gestures.DownUpEventArgs e)
        {
            //TODO Navigate user to settings page
            btnSettings.BackgroundColor = Color.FromHex("#6caefa");
        }
        private void btnSettings_Released(object sender, MR.Gestures.DownUpEventArgs e)
        {
            
            btnSettings.BackgroundColor = Color.FromHex("#2196F3");
        }
        private void btnTwitter_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate user to RACEME Twitter page
        }
        private void btnFacebook_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate user to RACEME Facebook page
        }
        private void btnInstagram_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate user to RACEME Instagram page
        }

        private void btnMyRoutes_Up(object sender, MR.Gestures.DownUpEventArgs e)
        {

        }
    }
}