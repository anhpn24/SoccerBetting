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
    public partial class Setting : BaseContentPage<SettingViewModel>
    {
        public Setting()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Thông báo", "Bạn thực sự muốn đăng xuất?", "Có", "Không");
            if (answer)
            {
                await Navigation.PushAsync(new Login());
            }            
        }
    }
}