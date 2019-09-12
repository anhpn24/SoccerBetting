using SoccerBetting.Models;
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
        public History()
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "All", "Match Played", "Match not play");
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var itemData = e.SelectedItem as MatchHistory;

                if (itemData.Status == (int)StatusMatchEnum.Finished)
                {
                    await DisplayAlert("Alert", "Match Finished. You not continue betting", "OK");
                }
                else
                {
                    await Navigation.PushAsync(new DetailMatch()
                    {
                        BindingContext = e.SelectedItem as MatchHistory
                    });
                }                
            }
        }
    }
}