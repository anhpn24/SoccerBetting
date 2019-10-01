using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoccerBetting.Controls
{
    public class CustomPicker : Picker
    {
        // BorderRadius
        public static readonly BindableProperty BorderRadiusProperty =
            BindableProperty.Create("BorderRadius", typeof(double), typeof(double), 0.0d);
        public double BorderRadius
        {
            get
            {
                return (double)GetValue(BorderRadiusProperty);
            }
            set
            {
                SetValue(BorderRadiusProperty, value);
            }
        }

        // BorderWidth
        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create("BorderWidth", typeof(int), typeof(int), 0);
        public int BorderWidth
        {
            get
            {
                return (int)GetValue(BorderWidthProperty);
            }
            set
            {
                SetValue(BorderWidthProperty, value);
            }
        }

        // BorderColor
        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create("BorderColor", typeof(Color), typeof(Color), Color.Transparent);
        public Color BorderColor
        {
            get
            {
                return (Color)GetValue(BorderColorProperty);
            }
            set
            {
                SetValue(BorderColorProperty, value);
            }
        }

        // BgColor
        public static readonly BindableProperty BgColorProperty =
            BindableProperty.Create("BgColor", typeof(Color), typeof(Color), Color.White);
        public Color BgColor
        {
            get
            {
                return (Color)GetValue(BgColorProperty);
            }
            set
            {
                SetValue(BgColorProperty, value);
            }
        }
    }
}
