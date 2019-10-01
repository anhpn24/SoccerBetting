using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoccerBetting.Controls
{
    public class RoundedStackLayout : StackLayout
    {
        // ConnerRadius
        public static readonly BindableProperty RoundedConnerRadiusProperty =
            BindableProperty.Create("RoundedCornerRadius", typeof(double), typeof(double), 0.0d);
        public double RoundedCornerRadius
        {
            get
            {
                return (double)GetValue(RoundedConnerRadiusProperty);
            }
            set
            {
                SetValue(RoundedConnerRadiusProperty, value);
            }
        }

        // Bottom-Left
        public static readonly BindableProperty BottomLeftProperty =
            BindableProperty.Create("BottomLeft", typeof(bool), typeof(bool), true);
        public bool BottomLeft
        {
            get
            {
                return (bool)GetValue(BottomLeftProperty);
            }
            set
            {
                SetValue(BottomLeftProperty, value);
            }
        }

        // Top-Left
        public static readonly BindableProperty TopLeftProperty =
            BindableProperty.Create("TopLeft", typeof(bool), typeof(bool), true);
        public bool TopLeft
        {
            get
            {
                return (bool)GetValue(TopLeftProperty);
            }
            set
            {
                SetValue(TopLeftProperty, value);
            }
        }

        // Top-Right
        public static readonly BindableProperty TopRightProperty =
            BindableProperty.Create("TopRight", typeof(bool), typeof(bool), true);
        public bool TopRight
        {
            get
            {
                return (bool)GetValue(TopRightProperty);
            }
            set
            {
                SetValue(TopRightProperty, value);
            }
        }

        // Bottom-Right
        public static readonly BindableProperty BottomRightProperty =
            BindableProperty.Create("BottomRight", typeof(bool), typeof(bool), true);
        public bool BottomRight
        {
            get
            {
                return (bool)GetValue(BottomRightProperty);
            }
            set
            {
                SetValue(BottomRightProperty, value);
            }
        }

        // BorderColor
        public static readonly BindableProperty BorderColorProperty = 
            BindableProperty.Create("BorderColor", typeof(Color), typeof(Color), Color.Transparent);
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        // BorderWidth
        public static readonly BindableProperty BorderWidthProperty = 
            BindableProperty.Create("BorderWidth", typeof(float), typeof(float), (float)0);
        public float BorderWidth
        {
            get
            {          
                if (Device.RuntimePlatform == Device.iOS)
                {
                    var borderWidth = (float)GetValue(BorderWidthProperty) - 3;
                    if (borderWidth > 0)
                    {
                        return borderWidth;
                    }
                    else
                    {
                        return 0;
                    }                    
                }

                return (float)GetValue(BorderWidthProperty);
            }
            set
            {
                SetValue(BorderWidthProperty, value);
            }
        }
    }
}


