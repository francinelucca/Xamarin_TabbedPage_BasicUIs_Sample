using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_TabbedPage_Sample.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryCategory : ContentView
    {
        public static readonly BindableProperty CategoryTitleProperty = BindableProperty.Create(nameof(CategoryTitle), typeof(string), typeof(DiscoveryCategory), string.Empty);
        public static readonly BindableProperty CategoryAvailabilityProperty = BindableProperty.Create(nameof(CategoryAvailability), typeof(string), typeof(DiscoveryCategory), string.Empty);
        public static readonly BindableProperty CategoryImageSourceProperty = BindableProperty.Create(nameof(CategoryImageSource), typeof(ImageSource), typeof(DiscoveryCategory), default(ImageSource));

        public string CategoryTitle
        {
            get => (string)GetValue(DiscoveryCategory.CategoryTitleProperty);
            set => SetValue(DiscoveryCategory.CategoryTitleProperty, value);
        }

        public string CategoryAvailability
        {
            get => $"{(string)GetValue(DiscoveryCategory.CategoryAvailabilityProperty)} Places";
            set => SetValue(DiscoveryCategory.CategoryAvailabilityProperty, value);
        }

        public ImageSource CategoryImageSource
        {
            get => (ImageSource)GetValue(DiscoveryCategory.CategoryImageSourceProperty);
            set => SetValue(DiscoveryCategory.CategoryImageSourceProperty, value);
        }

        public DiscoveryCategory()
        {
            InitializeComponent();
        }

        void OnCategoryToggle(System.Object sender, System.EventArgs e)
        {
            if (Category.BackgroundColor == Color.White)
            {
                Category.BackgroundColor = (Color)Application.Current.Resources["AppYellow"];
                Category.HasShadow = true;
                Availability.TextColor = Color.Black;

            }
            else
            {
                Category.BackgroundColor = Color.White;
                Category.HasShadow = false;
                Availability.TextColor = Color.LightGray;

            }
        }
    }
}
