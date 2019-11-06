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
    public partial class NewRoutesPage : ContentPage
    {
        public NewRoutesPage()
        {
            InitializeComponent();
        }

        private void btnFindRoute_Clicked(object sender, EventArgs e)
        {
            //TODO Navigate User to Avalible Routes Page
        }
    }
}