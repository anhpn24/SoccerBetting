using SoccerBetting.Interface;
using SoccerBetting.Models;
using SoccerBetting.Resources;
using SoccerBetting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoccerBetting.Views
{
    public partial class History : BaseContentPage<HistoryViewModel>
    {
        ViewCell lastCell;

        public History()
        {
            InitializeComponent();
            this.stLayout.Margin = new Thickness(15, 10, 15, 10);
            if (Device.RuntimePlatform == Device.iOS)
            {
                var isIphoneXDevice = DependencyService.Get<DeviceInfo>().IsIphoneXDevice();
                if (isIphoneXDevice)
                {
                    this.stLayout.Margin = new Thickness(15, 45, 15, 10);
                }
            }
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, AppResources.lblAll, AppResources.lblPlayed, AppResources.lblNotPlay);
        }

        private void ListHistory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}