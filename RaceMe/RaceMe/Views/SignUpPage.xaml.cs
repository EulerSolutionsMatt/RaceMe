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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void btnSignIn_Clicked(object sender,EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new SignInPage());
        }
        private void btnSignUp_Clicked(object sender,EventArgs e)
        {
            //TODO Creates account and stores in db , Navigates user to SignIn Page
        }
    }
}