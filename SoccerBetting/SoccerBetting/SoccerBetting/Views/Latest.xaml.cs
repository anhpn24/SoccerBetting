﻿using SoccerBetting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoccerBetting.Views
{
    public partial class Latest : BaseContentPage<LatestViewModel>
    {
        public Latest()
        {
            InitializeComponent();
            var demo = ViewModel.Response;
        }
    }
}