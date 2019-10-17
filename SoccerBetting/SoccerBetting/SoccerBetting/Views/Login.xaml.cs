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
    public partial class Login : BaseContentPage<LoginViewModel>
    { 
        public Login()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var isAuthenticated = true;
            if (isAuthenticated)
            {
                await Navigation.PushAsync(new MasterPage());
            }            
        }

        async void TapGesRegister_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        private void TapGesForgotPwd_Tapped(object sender, EventArgs e)
        {

        }
    }
}