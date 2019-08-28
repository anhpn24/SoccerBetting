using SoccerBetting.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoccerBetting.Views
{
    class BaseContentPage : ContentPage
    {
        public BaseContentPage() { }
    }

    public class BaseContentPage<T> : ContentPage where T : BaseViewModel
    {
        internal T ViewModel { get; private set; }
        public BaseContentPage()
        {
            ViewModel = Activator.CreateInstance<T>();
            BindingContext = ViewModel;
            //BackgroundColor = Color.LightGray;
        }
    }
}
