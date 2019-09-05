using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.Models
{
    public class MatchList
    {
        /// <summary>
        /// Ngay dien ra tran dau
        /// </summary>
        public DateTime PlayDate { get; set; }

        #region Display
        public string DisplayPlayDate
        {
            get
            {
                return this.PlayDate.ToString("ddMMyyyy");
            }
        }

        public string PlayDayInWeek
        {
            get
            {
                return this.PlayDate.DayOfWeek.ToString();
            }
        }

        public string PlayTime
        {
            get
            {
                return this.PlayDate.ToString("HH:mm");
            }
        }
        #endregion

    }
}
