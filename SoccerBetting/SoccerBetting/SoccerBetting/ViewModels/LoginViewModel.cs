using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Team teams { get; set; } = new Team();
    }
}
