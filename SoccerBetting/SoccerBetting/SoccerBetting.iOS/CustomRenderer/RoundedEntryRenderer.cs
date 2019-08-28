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

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(SoccerBetting.iOS.CustomRenderer.RoundedEntryRenderer))]
namespace SoccerBetting.iOS.CustomRenderer
{
    class RoundedEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var element = this.Element as RoundedEntry;
                Control.Layer.CornerRadius = (float)element.BorderRadius;
                Control.Layer.BorderWidth = (float)element.BorderWidth;
                Control.Layer.BorderColor = element.BorderColor.ToCGColor();
                Control.Layer.BackgroundColor = element.BgColor.ToCGColor();

                Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UITextFieldViewMode.Always;
            }
        }
    }
}