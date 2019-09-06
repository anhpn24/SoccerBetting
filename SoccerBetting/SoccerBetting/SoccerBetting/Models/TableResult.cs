using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class TableResult
    {
        public int Position { get; set; }
        public Team Team { get; set; }
        public int MatchKicked { get; set; }
        public int Point { get; set; }
        public string WLIndex { get; set; }
    }
}
