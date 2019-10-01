using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoccerBetting.Controls
{
    public class RoundedCornerView : ContentView
    {
        // ConnerRadius
        public static readonly BindableProperty ConnerRadiusProperty =
            BindableProperty.Create("CornerRadius", typeof(float), typeof(float), 0.0f);
        public float CornerRadius
        {
            get
            {
                return (float)GetValue(ConnerRadiusProperty);
            }
            set
            {
                SetValue(ConnerRadiusProperty, value);
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
            get { return (float)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }
    }
}
