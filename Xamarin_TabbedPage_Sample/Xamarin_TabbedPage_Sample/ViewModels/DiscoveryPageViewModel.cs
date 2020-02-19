using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_TabbedPage_Sample.Models;

namespace Xamarin_TabbedPage_Sample.ViewModels
{
	public class DiscoveryPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<DiscoveryCategory> DiscoveryCategories { get; set; } 
		public ICommand OnCategorySelectCommand { get; set; }


		public DiscoveryPageViewModel()
		{
			DiscoveryCategories = new ObservableCollection<DiscoveryCategory>()
			{
				new DiscoveryCategory{
					Name = "Bars & Hotels",
					Availability = 42,
					ImageSource = "beer.png",
					IsSelected = false
				},
				new DiscoveryCategory{
					Name = "Fine Dining",
					Availability = 15,
					ImageSource = "service.png",
					IsSelected = false
				},
				new DiscoveryCategory{
					Name = "Cafes",
					Availability = 28,
					ImageSource = "cafe.png",
					IsSelected = false
				},
				new DiscoveryCategory{
					Name = "Nearby",
					Availability = 34,
					ImageSource = "path.png",
					IsSelected = false
				},
				new DiscoveryCategory{
					Name = "Fast Foods",
					ImageSource = "food.png",
					Availability = 29,
					IsSelected = false
				},
				new DiscoveryCategory{
					Name = "Featured Foods",
					ImageSource = "pizza.png",
					Availability = 21,
					IsSelected = false
				}
			};
			OnCategorySelectCommand = new Command<DiscoveryCategory>(
				execute: (DiscoveryCategory selectedCategory) =>
				{
					foreach (var category in this.DiscoveryCategories)
					{
						category.IsSelected = category == selectedCategory;
					}
				}
				);
		}
	}
}
