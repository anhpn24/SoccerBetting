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
    public partial class Register : BaseContentPage<RegisterViewModel>
    {
        public Register()
        {
            InitializeComponent();
        }
        private void TapGesCheckBoxLicense_Tapped(object sender, EventArgs e)
        {
            this.checkBox.IsChecked = !this.checkBox.IsChecked;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private void TapGesLinkSupport_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}