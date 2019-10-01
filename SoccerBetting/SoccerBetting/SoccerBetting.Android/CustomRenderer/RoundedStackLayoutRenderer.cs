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
using Xamarin.Forms.Platform.Android;
using SoccerBetting.Controls;
using Android.Graphics;

[assembly: ExportRenderer(typeof(RoundedStackLayout), typeof(SoccerBetting.Droid.CustomRenderer.RoundedStackLayoutRenderer))]
namespace SoccerBetting.Droid.CustomRenderer
{
    class RoundedStackLayoutRenderer : VisualElementRenderer<RoundedStackLayout>
    {
        public RoundedStackLayoutRenderer(Context context) : base(context)
        {
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            if (Element == null || !Element.BottomLeft && !Element.BottomRight && !Element.TopLeft && !Element.TopRight)
                return;

            var density = Context.Resources.DisplayMetrics.Density;
            var color = Element.BackgroundColor.ToAndroid();

            SetBackgroundColor(Xamarin.Forms.Color.Transparent.ToAndroid());

            var rect = new RectF(0.0f, 0.0f, Width, Height);
            var paint = new Paint(PaintFlags.AntiAlias);
               
            float radius = (float)Element.RoundedCornerRadius * density;
            //paint.Color = color;
            //canvas.DrawRoundRect(rect, radius, radius, paint);

            //if (!Element.TopLeft)
            //{
            //    var rectTopLeft = new RectF(0.0f, 0.0f, radius, radius);
            //    canvas.DrawRect(rectTopLeft, paint);
            //}

            //if (!Element.BottomLeft)
            //{
            //    var rectBottomLeft = new RectF(0.0f, Height - radius, radius, Height);
            //    canvas.DrawRect(rectBottomLeft, paint);
            //}

            //if (!Element.TopRight)
            //{
            //    var rectTopRight = new RectF(Width - radius, 0.0f, Width, radius);
            //    canvas.DrawRect(rectTopRight, paint);
            //}

            //if (!Element.BottomRight)
            //{
            //    var rectBottomRight = new RectF(Width - radius, Height - radius, Width, Height);
            //    canvas.DrawRect(rectBottomRight, paint);
            //}

            var path = new Path();
            var topLeft = Element.TopLeft ? radius : 0;
            var topRight = Element.TopRight ? radius : 0;
            var bottomRight = Element.BottomRight ? radius : 0;
            var bottomLeft = Element.BottomLeft ? radius : 0;
            var radii = new[] { topLeft, topLeft, topRight, topRight, bottomRight, bottomRight, bottomLeft, bottomLeft };

            path.AddRoundRect(rect, radii, Path.Direction.Ccw);

            paint.SetStyle(Paint.Style.Fill);
            paint.Color = color;
            canvas.DrawPath(path, paint);

            if (Element.BorderWidth > 0)
            {
                paint.SetStyle(Paint.Style.Stroke);
                paint.StrokeWidth = Element.BorderWidth;                
                paint.Color = Element.BorderColor.ToAndroid();
                canvas.DrawPath(path, paint);
            }                
        }
    }
}