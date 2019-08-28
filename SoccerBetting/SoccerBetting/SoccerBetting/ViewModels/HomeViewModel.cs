using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Team teams { get; set; } = new Team();
    }
}
