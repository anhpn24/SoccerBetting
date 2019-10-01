using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoccerBetting.Models
{
    public class Match : BaseModel
    {
        /// <summary>
        /// Match Id
        /// </summary>
        public int Id { get; set; }
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
        /// Thoi gian bat dau tran dau
        /// </summary>
        public TimeSpan StartTime { get; set; }

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
        
        public string DisplayTime
        {
            get
            {
                return this.StartTime.ToString(@"hh\:mm");
            }
        }

        public Color DisplayBgColorTime
        {
            get
            {
                if (IsShowDetail)
                {
                    return Color.FromArgb(221, 221, 221);
                }

                return Color.White;

            }
        }
        public bool IsShowDetail { get; set; } = false;
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
