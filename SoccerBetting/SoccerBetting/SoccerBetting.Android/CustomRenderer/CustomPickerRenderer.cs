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
                var gradientDrawable = new GradientDrawable();
                //gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(5, Color.Transparent.ToAndroid());
                //gradientDrawable.SetColor(Color.LightGray.ToAndroid());

                Control.SetBackground(gradientDrawable);

                //Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
    }
}