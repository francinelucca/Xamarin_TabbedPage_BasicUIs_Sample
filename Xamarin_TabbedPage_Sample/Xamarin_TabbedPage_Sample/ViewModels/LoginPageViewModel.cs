using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_TabbedPage_Sample.Utils;


namespace Xamarin_TabbedPage_Sample.ViewModels
{
	public class LoginPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Password { get; set; }
        public string Email { get; set; }
        public bool HidePassword { get; set; }
        public string PasswordVisibilityIcon { get; set; }
        public ICommand OnGoToSignUpCommand { get; set; }
        public ICommand OnLoginCommand { get; set; }
        public ICommand OnPasswordToggleCommand { get; set; }
        public LoginPageViewModel()
		{
            PasswordVisibilityIcon = Utils.Icon.Visible;
            HidePassword = true;

            OnGoToSignUpCommand = new Command(
				execute: async () =>
				{
					await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(Email));
				}
				);

            OnLoginCommand = new Command(
                execute: async () =>
                {
                    if (await Validate())
                    {
                        await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                    }
                }
                );
            OnPasswordToggleCommand = new Command(
                execute: () =>
                {
                    HidePassword = !HidePassword;
                    PasswordVisibilityIcon = HidePassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
                });
        }


        private async Task<bool> Validate()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Email Field is Required", "Please enter an Email Address.", "OK");
                isValid = false;
            }
            else
            {
                if (!Email.IsValidEmail())
                {
                    await App.Current.MainPage.DisplayAlert("Email Address not valid", "Please enter a valid Email Address.", "OK");
                    isValid = false;
                }
            }
            if (String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Password Field is Required", "Please Enter a Password.", "OK");
                isValid = false;
            }
            else
            {
                if (!Password.IsValidPassword())
                {
                    await App.Current.MainPage.DisplayAlert("Password Address not valid",
                        "Please enter a valid Password: Must contain uppercase, lowercase and be at least 8 characters long.", "OK");
                    isValid = false;
                }

            }

            return isValid;
        }
    }
}
