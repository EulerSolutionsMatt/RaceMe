using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace RaceMe.Classes
{
    class Route
    {
        private string routeName; 
        private List<Location> routeList;
        private double routeDistance;
        private double bestTime;
        public string RouteName { get => routeName; set => routeName = value; }
        public List<Location> Routelist { get => routeList; set => routeList = value; }
        public double RouteDistance { get => routeDistance; set => routeDistance = value; }
        public double BestTime { get => bestTime; set => bestTime = value; }

        public Route(string routeName,List<Location> routeList,double routeDistance,double bestTime)
        {
            this.routeName = routeName;
            this.routeList = routeList;
            this.routeDistance = routeDistance;
            this.bestTime = bestTime;
        }
        public Route()
        {

        }
    }
}
