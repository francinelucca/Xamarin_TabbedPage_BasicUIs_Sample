using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_TabbedPage_Sample.Models
{
	public class DiscoveryCategory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public String Name { get; set; }
		public String ImageSource { get; set; }
		public int Availability { get; set; }
		public bool IsSelected { get; set; }

		public static DiscoveryCategory defaultValue = new DiscoveryCategory()
			{
				Name = "",
				ImageSource = "",
				Availability = 0,
				IsSelected = false
			};
	}
}
