using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class MatchList : List<Match>
    {
        /// <summary>
        /// Ngay dien ra tran dau
        /// </summary>
        public DateTime PlayDate { get; set; }

        /// <summary>
        /// Thông tin các trận đấu
        /// </summary>
        public List<Match> Matchs => this;

        #region Display
        public string DisplayPlayDate
        {
            get
            {
                return this.PlayDate.DayOfWeek.ToString() + ", "+ this.PlayDate.ToString("dd/MM/yyyy");
            }
        }

        public string DisplayMatchTime
        {
            get
            {
                return this.PlayDate.ToString("HH:mm");
            }
        }
        #endregion

    }
}
