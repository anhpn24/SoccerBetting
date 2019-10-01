using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SoccerBetting.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedCornerView), typeof(SoccerBetting.Droid.CustomRenderer.RoundedCornerViewRenderer))]
namespace SoccerBetting.Droid.CustomRenderer
{
    public class RoundedCornerViewRenderer : ViewRenderer
    {
        public RoundedCornerViewRenderer(Context context) : base(context)
        {
        }

        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {
            if (Element == null) return false;

            var control = (RoundedCornerView)Element;

            SetClipChildren(true);

            control.Padding = new Thickness(0, 0, 0, 0);

            //Create path to clip the child         
            var path = new Path();
            path.AddRoundRect(new RectF(0, 0, Width, Height),
                              GetRadii(control),
                              Path.Direction.Ccw);

            canvas.Save();
            canvas.ClipPath(path);

            // Draw the child first so that the border shows up above it.        
            var result = base.DrawChild(canvas, child, drawingTime);

            canvas.Restore();

            DrawBorder(canvas, control, path);

            //Properly dispose        
            path.Dispose();
            return result;
        }

        private static float[] GetRadii(RoundedCornerView control)
        {
            var radius = (float)(control.CornerRadius);
            radius *= 2;

            var topLeft = control.TopLeft ? radius : 0;
            var topRight = control.TopRight ? radius : 0;
            var bottomLeft = control.BottomLeft ? radius : 0;
            var bottomRight = control.BottomRight ? radius : 0;

            if (!control.BottomLeft && !control.BottomRight && !control.TopLeft && !control.TopRight)
                topLeft = topRight = bottomLeft = bottomRight = radius;

            var radii = new[] { topLeft, topLeft, topRight, topRight, bottomRight, bottomRight, bottomLeft, bottomLeft };
            return radii;
        }

        private static void DrawBorder(Canvas canvas, RoundedCornerView control, Path path)
        {
            if (control.BorderColor == Xamarin.Forms.Color.Transparent || control.BorderWidth <= 0) return;

            var paint = new Paint();
            paint.AntiAlias = true;
            paint.StrokeWidth = control.BorderWidth;
            paint.SetStyle(Paint.Style.Stroke);
            paint.Color = control.BorderColor.ToAndroid();

            canvas.DrawPath(path, paint);

            paint.Dispose();
        }
    }
}