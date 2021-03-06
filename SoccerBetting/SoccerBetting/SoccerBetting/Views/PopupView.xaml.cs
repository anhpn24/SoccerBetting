﻿using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoccerBetting.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : PopupPage
    {
        public PopupView()
        {
            InitializeComponent();            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var model = (Match)BindingContext;
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}