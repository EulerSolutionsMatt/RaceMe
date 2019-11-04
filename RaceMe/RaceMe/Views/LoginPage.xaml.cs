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
        public void LoginClicked(object sender,EventArgs e){
            Navigation.PushAsync(new SignInPage());
            
        }
        public void SignUpClicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}