using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoccerBetting.Views
{
    public partial class MasterPage : BottomBarPage
    {
        public MasterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        private void BottomBarPage_CurrentPageChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;            
        }
    }
}