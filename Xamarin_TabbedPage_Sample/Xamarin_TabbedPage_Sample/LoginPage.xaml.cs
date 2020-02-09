using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_TabbedPage_Sample.Utils;

namespace Xamarin_TabbedPage_Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void ShowPassword(object sender, EventArgs args)
        {
            Password.IsPassword = !Password.IsPassword;
            Visibility.Text = Password.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            Password.FontAttributes = FontAttributes.Bold;
        }

        public void FocusPassword(object sender, EventArgs args)
        {
            Password.Focus();
        }


        private async void GoToSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage(Email.Text ?? ""));
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            if (await Validate())
            {
                await Navigation.PushAsync(new HomePage());
            }
        }

        private async Task<bool> Validate()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(Email.Text))
            {
                await DisplayAlert("Email Field is Required", "Please enter an Email Address", "OK");
                isValid = false;
            }
            else
            {
                if (!StringValidator.IsEmailValid(Email.Text))
                {
                    await DisplayAlert("Email Address not valid", "Please enter a valid Email Address", "OK");
                    isValid = false;
                }
            }
            if (String.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Password Field is Required", "Please Enter a Password", "OK");
                isValid = false;
            }

            return isValid;
        }
    }
}