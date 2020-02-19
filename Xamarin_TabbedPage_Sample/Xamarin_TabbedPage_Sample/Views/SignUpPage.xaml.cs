using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_TabbedPage_Sample.ViewModels;

namespace Xamarin_TabbedPage_Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string emailAddress)
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel(emailAddress);
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
    }
}