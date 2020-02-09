using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin_TabbedPage_Sample.Droid.CustomRenders;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace Xamarin_TabbedPage_Sample.Droid.CustomRenders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.LightGray);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.LightGray, PorterDuff.Mode.SrcAtop);
        }
    }
}