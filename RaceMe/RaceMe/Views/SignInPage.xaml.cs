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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        private void btnSignUp_Clicked(object sender,EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new SignUpPage());
        }
        private void btnSignIn_Clicked(object sender,EventArgs e)
        {
            //TODO Checks entered credentials and takes user to homescreen
        }
        
    }
}