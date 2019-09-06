using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class SettingViewModel : BaseViewModel
    {
        public User userInfo { get; set; }

        public SettingViewModel()
        {
            userInfo = new User
            {
                Id = Guid.NewGuid(),
                UserName = "Michel John",
                Email = "micheljohn@csa.com.us",
                LastLogin = DateTime.Now,
                Point = 100,
                Image = "paw.png",
                AllowBetting = true
            };            
        }



    }
}
