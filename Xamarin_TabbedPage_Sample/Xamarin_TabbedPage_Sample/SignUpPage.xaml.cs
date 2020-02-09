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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string emailAddress)
        {
            InitializeComponent();
            Email.Text = emailAddress;
        }

        public void ShowPassword(object sender, EventArgs args)
        {
            Password.IsPassword = !Password.IsPassword;
            PasswordVisibility.Text = Password.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            Password.FontAttributes = FontAttributes.Bold;
        }

        public void ShowPasswordRepeat(object sender, EventArgs args)
        {
            PasswordRepeat.IsPassword = !PasswordRepeat.IsPassword;
            PasswordRepeatVisibility.Text = PasswordRepeat.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            PasswordRepeat.FontAttributes = FontAttributes.Bold;
        }

        public void FocusUsername(object sender, EventArgs args)
        {
            Username.Focus();
        }

        public void FocusPassword(object sender, EventArgs args)
        {
            Password.Focus();
        }

        public void FocusPasswordRepeat(object sender, EventArgs args)
        {
            PasswordRepeat.Focus();
        }


        private async void GoToLogin(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        private async void OnSignUp(object sender, EventArgs e)
        {
            if (await Validate())
            {
                await Navigation.PushAsync(new MainPage());
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
                if (!Email.Text.IsValidEmail())
                {
                    await DisplayAlert("Email Address not valid", "Please enter a valid Email Address", "OK");
                    isValid = false;
                }
            }
            if (String.IsNullOrEmpty(Username.Text))
            {
                await DisplayAlert("Username Field is Required", "Please Enter a Username", "OK");
                isValid = false;
            }
            if (String.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Password Field is Required", "Please Enter a Password", "OK");
                isValid = false;
            }
            else
            {
                if (!Password.Text.IsValidPassword())
                {
                    await DisplayAlert("Password Address not valid",
                        "Please enter a valid Password: Must contain uppercase, lowercase and be at least 8 characters long.", "OK");
                    isValid = false;
                }
                if (!String.IsNullOrEmpty(PasswordRepeat.Text) && (PasswordRepeat.Text != Password.Text))
                {
                    await DisplayAlert("Passwords Don't Match!", "Please make sure the password entered at both fields is the same", "OK");
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}