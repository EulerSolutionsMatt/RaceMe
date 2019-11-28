using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaceMe.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompletedRouteView : ContentView
    {
        public static readonly BindableProperty RouteNameProperty =
            BindableProperty.Create("RouteName", typeof(string), typeof(CompletedRouteView), default(string));
        private string routeName;
        public string RouteName
        {
            get => (string)GetValue(RouteNameProperty);
            set => SetValue(RouteNameProperty, value);
        }


        public static readonly BindableProperty LocationProperty =
            BindableProperty.Create("Location", typeof(string), typeof(CompletedRouteView), default(string));
        private string location;
        public string Location
        {
            get => (string)GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }


        public static readonly BindableProperty BestTimeProperty =
            BindableProperty.Create("BestTime", typeof(string), typeof(CompletedRouteView), default(string));
        private string bestTime;
        public string BestTime
        {
            get => (string)GetValue(BestTimeProperty);
            set => SetValue(BestTimeProperty, value);
        }


        public static readonly BindableProperty DistanceProperty =
            BindableProperty.Create("Distance", typeof(string), typeof(CompletedRouteView), default(string));
        private string distance;
        public string Distance
        {
            get => (string)GetValue(DistanceProperty);
            set => SetValue(DistanceProperty, value);
        }



        public CompletedRouteView()
        {
            InitializeComponent();

            lblRouteName.SetBinding(Label.TextProperty, new Binding("RouteName", source: this));
            lblLocation.SetBinding(Label.TextProperty, new Binding("Location", source: this));
            lblBestTime.SetBinding(Label.TextProperty, new Binding("BestTime", source: this));
            lblDistance.SetBinding(Label.TextProperty, new Binding("Distance", source: this));
        }



    }
}