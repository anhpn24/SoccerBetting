using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using SoccerBetting.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedCornerView), typeof(SoccerBetting.iOS.CustomRenderer.RoundedCornerViewRenderer))]
namespace SoccerBetting.iOS.CustomRenderer
{
    public class RoundedCornerViewRenderer : ViewRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (NativeView != null)
            {
                NativeView.SetNeedsDisplay();
                NativeView.SetNeedsLayout();
            }
        }

        public override void Draw(CoreGraphics.CGRect rect)
        {
            base.Draw(rect);
            this.LayoutIfNeeded();

            var control = (RoundedCornerView)Element;
            UIRectCorner uIRectCorner = 0;

            if (control != null)
            {                
                if (control.TopLeft) uIRectCorner |= UIRectCorner.TopLeft;
                if (control.TopRight) uIRectCorner |= UIRectCorner.TopRight;
                if (control.BottomLeft) uIRectCorner |= UIRectCorner.BottomRight;
                if (control.BottomRight) uIRectCorner |= UIRectCorner.BottomLeft;

                if (!control.BottomLeft && !control.BottomRight && !control.TopLeft && !control.TopRight)
                    uIRectCorner = UIRectCorner.AllCorners;

                nfloat radius = control.CornerRadius;
                var maskingShapeLayer = new CAShapeLayer
                {
                    Path = UIBezierPath.FromRoundedRect(Bounds, uIRectCorner, new CGSize(radius, radius)).CGPath
                };
                Layer.Mask = maskingShapeLayer;

                this.ClipsToBounds = true;
                this.Layer.MasksToBounds = true;
                this.Layer.BorderWidth = control.BorderWidth;

                if (control.BorderWidth > 0)
                {
                    control.Padding = new Thickness(control.BorderWidth);
                    this.Layer.BorderColor = control.BorderColor.ToCGColor();                    
                }
            }
        }
    }
}