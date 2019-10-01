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

[assembly: ExportRenderer(typeof(CustomPicker), typeof(SoccerBetting.iOS.CustomRenderer.CustomPickerRenderer))]
namespace SoccerBetting.iOS.CustomRenderer
{
    class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var element = this.Element as CustomPicker;
                Control.Layer.CornerRadius = (float)element.BorderRadius;
                Control.Layer.BorderWidth = (float)element.BorderWidth;
                Control.Layer.BorderColor = element.BorderColor.ToCGColor();
                Control.Layer.BackgroundColor = element.BgColor.ToCGColor();
                Control.Layer.MasksToBounds = true;

                Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UITextFieldViewMode.Always;
            }
        }
    }
}