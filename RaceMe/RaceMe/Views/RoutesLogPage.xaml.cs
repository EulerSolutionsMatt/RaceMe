using RaceMe.Classes;
using RaceMe.Controls;
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
    public partial class RoutesLogPage : ContentPage
    {
        public RoutesLogPage()
        {
            InitializeComponent();
            //List<Route> routeList = new List<Route>();
            //routeList.Add(new Route(
            //    "Route One",
            //    new List<Location>() { new Location(15,25),
            //        new Location(25,15)}
            //    ,25,21));
            //routeList.Add(new Route(
            //    "Route Two",
            //    new List<Location>() { new Location(15,25),
            //        new Location(25,15)}
            //    , 29, 12));
            //routeList.Add(new Route(
            //    "Route Three",
            //    new List<Location>() { new Location(15,25),
            //        new Location(25,15)}
            //    , 75, 100));

            //List<CompletedRouteView> viewList = new List<CompletedRouteView>();
            //foreach (Route item in routeList)
            //{
            //    CompletedRouteView temp = new CompletedRouteView();
            //    temp.RouteName = item.RouteName;
            //    temp.Location = "Temp Location";
            //    temp.BestTime = item.BestTime.ToString();
            //    temp.Distance = item.RouteDistance.ToString();
            //    viewList.Add(temp);
            //}



            CompletedRouteView temp = new CompletedRouteView();
            temp.RouteName = "Route One ";
            temp.Location = "Temp Location";
            temp.BestTime = "25";
            temp.Distance = "27";

            mainLayout.Children.Add(temp);
        }






    }
}