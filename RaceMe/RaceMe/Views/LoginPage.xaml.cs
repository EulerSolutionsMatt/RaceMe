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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void btnLogin_Clicked(object sender,EventArgs e){
            Navigation.PushAsync(new SignInPage());
            
        }
        private void btnSignUp_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void btnFacebook_Clicked(object sender, EventArgs e)
        {
            //TODO Logs user in using facebook credentials
        }
        private void btnGoogle_Clicked(object sender, EventArgs e)
        {
            //TODO logs user in using google credentials
        }
    }
}