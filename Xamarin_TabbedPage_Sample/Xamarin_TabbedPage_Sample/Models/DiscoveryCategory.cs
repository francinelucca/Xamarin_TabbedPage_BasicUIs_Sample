using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_TabbedPage_Sample.Models
{
	public class DiscoveryCategory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public string Name { get; set; }
		public string ImageSource { get; set; }
		public int Availability { get; set; }
		public bool IsSelected { get; set; }
	}
}
