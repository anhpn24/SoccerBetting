using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class TeamList : List<Team>
    {
        public DateTime PlayDate { get; set; }
        public List<Team> Persons => this;
    }
}
