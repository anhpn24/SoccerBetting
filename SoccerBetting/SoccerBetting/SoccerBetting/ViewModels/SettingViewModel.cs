using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class SettingViewModel : BaseViewModel
    {
        public Animal Bear { get; set; }

        public SettingViewModel()
        {
            Bear = new Animal
            {
                Name = "American Black Bear",
                Location = "North America",
                Details = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
            };            
        }



    }
}
