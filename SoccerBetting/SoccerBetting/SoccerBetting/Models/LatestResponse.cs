using System;
using System.Collections.Generic;
using System.Text;
using SoccerBetting.Models;
using SoccerBetting.Models.Common;

namespace SoccerBetting.Models
{
    public class LatestResponse : BaseResponse
    {
        public List<MatchList> listOfMatch { get; set; }
    }
}
