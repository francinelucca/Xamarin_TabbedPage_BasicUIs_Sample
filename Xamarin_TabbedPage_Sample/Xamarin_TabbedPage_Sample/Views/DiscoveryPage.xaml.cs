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
	public partial class DiscoveryPage : ContentPage
	{
		public DiscoveryPage ()
		{
			InitializeComponent();
			this.BindingContext = new DiscoveryPageViewModel();
        }
	}
}