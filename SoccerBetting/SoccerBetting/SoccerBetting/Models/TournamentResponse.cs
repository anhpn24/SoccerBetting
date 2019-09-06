using System;
using System.Collections.Generic;
using System.Text;
using SoccerBetting.Models.Common;

namespace SoccerBetting.Models
{
    public class TournamentResponse : BaseResponse
    {
        public TableResultList TblResult { get; set; }
        public List<TableResultList> ListOfTblResult { get; set; }
    }
}
