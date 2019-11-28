using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace RaceMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RouteDetailsPage : ContentPage
    {
        public RouteDetailsPage()
        {
            InitializeComponent();
        }

        // ----------------- GET & REVERSE GEOCODE CURRENT LOCATION -----------------
        /**
         * Gets the users last known location &reverse geocode it into GPS coords
         */
        async void Reverse_Geocode_Current_Location(object sender, System.EventArgs e)
        {
            try
            {

                // get current user location
                var current_location = await Geolocation.GetLastKnownLocationAsync();

                // reverse geocode current_location 
                var locations = await Geocoding.GetPlacemarksAsync(current_location.Latitude, current_location.Longitude);

                // get the first location
                var first_location = locations?.FirstOrDefault();

                var geocodeAddress =
                    $"AdminArea:       {first_location.AdminArea}\n" +
                    $"CountryCode:     {first_location.CountryCode}\n" +
                    $"CountryName:     {first_location.CountryName}\n" +
                    $"FeatureName:     {first_location.FeatureName}\n" +
                    $"Locality:        {first_location.Locality}\n" +
                    $"PostalCode:      {first_location.PostalCode}\n" +
                    $"SubAdminArea:    {first_location.SubAdminArea}\n" +
                    $"SubLocality:     {first_location.SubLocality}\n" +
                    $"SubThoroughfare: {first_location.SubThoroughfare}\n" +
                    $"Thoroughfare:    {first_location.Thoroughfare}\n";

                await DisplayAlert("Alert", geocodeAddress, "OK");


                // add a pin on the map at the users current location
                Pin pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(current_location.Latitude, current_location.Longitude),
                    Label = "Your Location",
                    Address = geocodeAddress
                };

                MyMap.Pins.Add(pin);

                // position map over users current location
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(current_location.Latitude, current_location.Longitude),
                                             Distance.FromMiles(1)));

            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }




        }
    }
}