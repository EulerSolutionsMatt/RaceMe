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
        private void btnMyRoutes_Clicked(object sender, EventArgs e)
        {
            //TODO navigate user to RoutesLogPage
        }
        private void btnNewRoute_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate user to NewRoutePage
        }
        private void btnSettings_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate user to settings page
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
        
    }
}