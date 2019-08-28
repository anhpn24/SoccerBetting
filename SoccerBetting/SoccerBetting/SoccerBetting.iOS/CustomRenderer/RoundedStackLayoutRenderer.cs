using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using SoccerBetting.Controls;
using Xamarin.Forms.Platform.iOS;
using CoreAnimation;
using CoreGraphics;

[assembly: ExportRenderer(typeof(RoundedStackLayout), typeof(SoccerBetting.iOS.CustomRenderer.RoundedStackLayoutRenderer))]
namespace SoccerBetting.iOS.CustomRenderer
{
    class RoundedStackLayoutRenderer : VisualElementRenderer<RoundedStackLayout>
    {
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            if (Element == null || !Element.BottomLeft && !Element.BottomRight && !Element.TopLeft && !Element.TopRight)
                return;

            UIRectCorner uIRectCorner = 0;
            if (Element.BottomLeft) uIRectCorner |= UIRectCorner.BottomLeft;
            if (Element.TopLeft) uIRectCorner |= UIRectCorner.TopLeft;
            if (Element.TopRight) uIRectCorner |= UIRectCorner.TopRight;
            if (Element.BottomRight) uIRectCorner |= UIRectCorner.BottomRight;

            nfloat radius = (nfloat)Element.RoundedCornerRadius;
            var maskingShapeLayer = new CAShapeLayer
            {
                Path = UIBezierPath.FromRoundedRect(Bounds, uIRectCorner, new CGSize(radius, radius)).CGPath
            };
            Layer.Mask = maskingShapeLayer;
        }
    }
}