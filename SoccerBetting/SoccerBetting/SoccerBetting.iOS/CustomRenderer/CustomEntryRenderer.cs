using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using SoccerBetting.Controls;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(SoccerBetting.iOS.CustomRenderer.CustomEntryRenderer))]
namespace SoccerBetting.iOS.CustomRenderer
{
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.Layer.CornerRadius = 10;
                Control.Layer.BorderWidth = 5.0f;
                Control.Layer.BorderColor = Color.Transparent.ToCGColor();
                //Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

                Control.BorderStyle = UITextBorderStyle.None;

                //Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                //Control.LeftViewMode = UITextFieldViewMode.Always;
            }
        }
    }
}