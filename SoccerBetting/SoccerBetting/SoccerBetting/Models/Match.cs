using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoccerBetting.Models
{
    public class Match
    {
        /// <summary>
        /// Thong tin doi 1
        /// </summary>
        public Team Team1 { get; set; } = new Team();

        /// <summary>
        /// Thong tin doi 2
        /// </summary>
        public Team Team2 { get; set; } = new Team();

        /// <summary>
        /// San van dong dien ra tran dau
        /// </summary>
        public string Stadium { get; set; }

        /// <summary>
        /// Kenh xem truc tuyen tran dau
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// So ban thang cua doi 1
        /// </summary>
        public int? ScoreTeam1 { get; set; }

        /// <summary>
        /// So ban thang cua doi 2
        /// </summary>
        public int? ScoreTeam2 { get; set; }
        
        /// <summary>
        /// Du doan cua user ve KQ tran dau
        /// 0 : Team 1 win
        /// 1 : Draw
        /// 2 : Team 2 win
        /// </summary>        
        public int? TypeGuess { get; set; }

        /// <summary>
        /// Diem dat cuoc cua user cho tran dau
        /// </summary>
        public int? BetPoint { get; set; }

        /// <summary>
        /// 0: Da dien ra
        /// 1: Dang dien ra
        /// 2: Chua dien ra
        /// </summary>
        public int Status { get; set; }

        #region Display

        public string DisplayScore
        {
            get
            {
                if (this.ScoreTeam1 != null || this.ScoreTeam1 != null)
                {
                    return this.ScoreTeam1.ToString() + " - " + this.ScoreTeam2.ToString();
                }

                return string.Empty;
            }
        }              
   
        #endregion
    }

    public enum TypeGuessEnum
    {
        Team1Win = 0,
        Draw = 1,
        Team2Win = 2,
    }

    public enum StatusMatchEnum
    {
        Finished = 0,
        IsKicking = 1,
        NotStart = 2
    }
}
