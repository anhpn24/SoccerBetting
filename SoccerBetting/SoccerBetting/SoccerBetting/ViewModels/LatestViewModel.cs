using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class LatestViewModel : BaseViewModel
    {
        public LatestResponse response { get; set; }
        public List<TeamList> ListOfTeam { get; set; }
        public LatestViewModel()
        {
            setData();
        }        

        public void setData()
        {
            var sList = new TeamList()
            {
                new Team() { Id = 0, Name = "Sampson", Image = "back.png" },
                new Team() { Id = 1, Name = "Swift", Image = "back.png" },
                new Team() { Id = 2, Name = "Smith", Image = "back.png" }
            };
            sList.PlayDate = DateTime.Now;

            var dList = new TeamList()
            {
                new Team() { Id = 2, Name = "Doe", Image = "back.png" }
            };
            dList.PlayDate = DateTime.Now.AddDays(1);

            var jList = new TeamList()
            {
                new Team() { Id = 1, Name = "Joel", Image = "back.png" }
            };
            jList.PlayDate = DateTime.Now.AddDays(2);

            var aList = new TeamList()
            {
                new Team() { Id = 0, Name = "Sampson", Image = "back.png" },
                new Team() { Id = 1, Name = "Swift", Image = "back.png" },
                new Team() { Id = 2, Name = "Smith", Image = "back.png" }
            };
            aList.PlayDate = DateTime.Now;

            var bList = new TeamList()
            {
                new Team() { Id = 0, Name = "Sampson", Image = "back.png" },
                new Team() { Id = 1, Name = "Swift", Image = "back.png" },
                new Team() { Id = 2, Name = "Smith", Image = "back.png" }
            };
            bList.PlayDate = DateTime.Now;

            var cList = new TeamList()
            {
                new Team() { Id = 0, Name = "Sampson", Image = "back.png" },
                new Team() { Id = 1, Name = "Swift", Image = "back.png" },
                new Team() { Id = 2, Name = "Smith", Image = "back.png" }
            };
            cList.PlayDate = DateTime.Now;

            var eList = new TeamList()
            {
                new Team() { Id = 0, Name = "Sampson", Image = "back.png" },
                new Team() { Id = 1, Name = "Swift", Image = "back.png" },
                new Team() { Id = 2, Name = "Smith", Image = "back.png" }
            };
            eList.PlayDate = DateTime.Now;

            var list = new List<TeamList>()
            {
                sList,
                dList,
                jList,
                eList,
                aList,
                bList,
                cList
            };

            ListOfTeam = list;
        }
    }
}
