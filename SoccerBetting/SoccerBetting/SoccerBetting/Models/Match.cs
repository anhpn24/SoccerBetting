using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoccerBetting.Models
{
    public class Match
    {
        /// <summary>
        /// Giai doan: 
        /// 0: Vong bang
        /// 1: Tu ket
        /// 2: Ban ket
        /// 3: Chung ket
        /// 4: Tranh hang ba
        /// </summary>
        public int TypeRound { get; set; }

        /// <summary>
        /// Ngay dien ra tran dau
        /// </summary>
        public DateTime PlayDate { get; set; }

        /// <summary>
        /// Thong tin doi 1
        /// </summary>
        public Team Team1 { get; set; }

        /// <summary>
        /// Thong tin doi 2
        /// </summary>
        public Team Team2 { get; set; }

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

        #region Display

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

        public Color DisplayResultBetting
        {
            get
            {
                if (TypeGuess == null)
                {
                    return Color.Gray;
                }

                if (ScoreTeam1 == null || ScoreTeam2 == null)
                {
                    return Color.Gray;
                }

                if ((ScoreTeam1 > ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Team1Win) ||
                    (ScoreTeam1 < ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Team2Win) ||
                    (ScoreTeam1 == ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Draw))
                {
                    return Color.Green;
                }
                else
                {
                    return Color.Red;
                }
            }
        }

        public string DisplayAmount
        {
            get
            {
                if (TypeGuess == null)
                {
                    return "--";
                }

                if (ScoreTeam1 == null || ScoreTeam2 == null)
                {
                    return "--";
                }

                if ((ScoreTeam1 > ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Team1Win) ||
                    (ScoreTeam1 < ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Team2Win) ||
                    (ScoreTeam1 == ScoreTeam2 && TypeGuess == (int)TypeGuessEnum.Draw))
                {
                    return "+" + (Convert.ToInt32(BetPoint) * 2).ToString();
                }
                else
                {
                    return "-" + Convert.ToInt32(BetPoint).ToString();
                }
            }
        }

        public string DisplayUserBet
        {
            get
            {
                if (TypeGuess == null)
                {
                    return "";
                }

                if (TypeGuess == 0)
                {
                    return Team1.Name + "win";
                }
                else if (TypeGuess == 2)
                {
                    return Team1.Name + "win";
                }
                else
                {
                    return "Draw";
                }
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
}
