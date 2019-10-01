using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SoccerBetting.Controls;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(SoccerBetting.Droid.CustomRenderer.CustomPickerRenderer))]
namespace SoccerBetting.Droid.CustomRenderer
{
    class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var element = this.Element as CustomPicker;
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius((float)element.BorderRadius);
                gradientDrawable.SetStroke((int)element.BorderWidth, ((Color)element.BorderColor).ToAndroid());
                gradientDrawable.SetColor(((Color)element.BgColor).ToAndroid());

                Control.SetBackground(gradientDrawable);

                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
    }
}