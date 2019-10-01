using System;
using System.Collections.Generic;
using System.Text;
using SoccerBetting.Models;
using SoccerBetting.Models.Common;

namespace SoccerBetting.Models
{
    public class HomeResponse : BaseResponse
    {
        public List<MatchList> listOfMatch { get; set; }
        public double SumHeightMatch
        {
            get
            {
                double rel = 0;
                double paddingStLay = 10;
                if (listOfMatch.Count == 0) return 0;
                
                for (int i = 0; i < listOfMatch.Count; i++)
                {
                    rel += listOfMatch[i].CountItem * (70 + 25.5);
                }

                rel = rel + paddingStLay * 2 + listOfMatch.Count * 30;

                return rel;
            }
        }

        public List<New> listNew { get; set; } = new List<New>();
        public double SumHeightNew
        {
            get
            {
                double rel = 0;
                if (listNew.Count == 0) return 0;
                rel = listNew.Count * 80 + 5;
                return rel;
            }
        }

        public List<Ads> listAds { get; set; } = new List<Ads>();

        public List<TableResultList> listOfTeamRank { get; set; }
    }

    public class Ads
    {
        public int Id { get; set; }
        public string Image { get; set; }
    }
}
