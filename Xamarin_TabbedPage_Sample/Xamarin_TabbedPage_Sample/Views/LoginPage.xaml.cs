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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
        public void FocusPassword(object sender, EventArgs args)
        {
            Password.Focus();
        }
    }
}