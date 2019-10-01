using Rg.Plugins.Popup.Services;
using SoccerBetting.Interface;
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
    public partial class Home : BaseContentPage<HomeViewModel>
    {
        ViewCell lastCell;
        Match curMatch;
        Match latestMatch;

        public Home()
        {
            InitializeComponent();
        }

        private void ViewCellMatch_Tapped(object sender, System.EventArgs e)
        {            
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#ddd");
                lastCell = viewCell;
            }

            PopupNavigation.Instance.PushAsync(new PopupView() { BindingContext = curMatch });
        }

        private void ViewCellNew_Tapped(object sender, System.EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#ddd");
                lastCell = viewCell;                
            }
        }

        private void ViewCellRank_Tapped(object sender, System.EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#ddd");
                lastCell = viewCell;
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            latestMatch = curMatch;
            curMatch = e.SelectedItem as Match;
            
            if (latestMatch != null)
            {
                latestMatch.IsShowDetail = false;
            }

            curMatch.IsShowDetail = true;
        }
    }
}