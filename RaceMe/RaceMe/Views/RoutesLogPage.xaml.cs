using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaceMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutesLogPage : ContentPage
    {

        // Dictionary used to store current gps coords
        Dictionary<string, string> CurrentLocation = new Dictionary<string, string>();

        public RoutesLogPage()
        {
            InitializeComponent();
        }


        // ----------------- GET CURRENT LOCATION FUNCTION -----------------
        /**
         * Returns users current location in a Dictionary.
         * 
         * TODO: move function to Services/Location.cs
         */
        async void Get_Current_Location(object sender, System.EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    // Add current GPS coords to CurrentLocation dictionary.
                    CurrentLocation.Add("latitude", location.Latitude.ToString());
                    CurrentLocation.Add("longitude", location.Longitude.ToString());
                    DisplayAlert("Success", CurrentLocation["latitude"], "Yay");
                    DisplayAlert("Success", CurrentLocation["longitude"], "Yay");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Faild", fnsEx.Message, "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Faild", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Faild", ex.Message, "OK");
            }

        }
    }
}