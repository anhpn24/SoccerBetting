using System;
using System.Collections.Generic;
using System.Text;
using SoccerBetting.Models.Common;

namespace SoccerBetting.Models
{
    public class LatestResponse : BaseResponse
    {
        public Records records { get; set; }
        public RecordList recordList { get; set; }
    }

    public class Records
    {
        
    }

    public class RecordList
    {
        public List<MatchList> listOfMatch { get; set; }
    }
}
