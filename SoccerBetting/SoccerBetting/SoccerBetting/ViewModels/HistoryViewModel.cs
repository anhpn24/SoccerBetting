using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        public IList<MatchHistory> historyMatch { get; set; }

        public HistoryViewModel()
        {
            setData();            
        }

        public void setData()
        {
            historyMatch = new List<MatchHistory>();
            var team1 = new Team { Id = 1, ShortName = "GER", Name = "Germany & England Scottlen", Image = "ger.png" };
            var team2 = new Team { Id = 2, ShortName = "FRA", Name = "France", Image = "fra.png" };

            var historyItem = new MatchHistory { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("07:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=60, ScoreTeam1=5, ScoreTeam2=1 };

            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel = "ic_kplus.png", StartTime = TimeSpan.Parse("07:00"), Status = (int)StatusMatchEnum.Finished, TypeGuess = (int)TypeGuessEnum.Team1Win, BetPoint = 60, ScoreTeam1 = 5, ScoreTeam2 = 1 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("08:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Draw, BetPoint=100, ScoreTeam1=3, ScoreTeam2=3 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ic_espn.png", StartTime= TimeSpan.Parse("09:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=80, ScoreTeam1=1, ScoreTeam2=7 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("10:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=30, ScoreTeam1=3, ScoreTeam2=3 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Santiago Bernabéu", Channel="ic_espn.png", StartTime= TimeSpan.Parse("11:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=50, ScoreTeam1=0, ScoreTeam2=3 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Camp Nou", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("12:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=120, ScoreTeam1=5, ScoreTeam2=1 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now, Team1 = team1, Team2 = team2, Stadium = "Allianz Arena", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("13:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=150, ScoreTeam1=3, ScoreTeam2=3 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-1), Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel = "ic_kplus.png", StartTime = TimeSpan.Parse("07:00"), Status = (int)StatusMatchEnum.Finished, TypeGuess = (int)TypeGuessEnum.Team2Win, BetPoint = 20, ScoreTeam1 = 1, ScoreTeam2 = 2 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-1), Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel = "ic_kplus.png", StartTime = TimeSpan.Parse("10:00"), Status = (int)StatusMatchEnum.Finished, TypeGuess = (int)TypeGuessEnum.Team2Win, BetPoint = 200, ScoreTeam1 = 0, ScoreTeam2 = 0 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-1), Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel = "ic_espn.png", StartTime = TimeSpan.Parse("18:00"), Status = (int)StatusMatchEnum.NotStart, TypeGuess = (int)TypeGuessEnum.Team2Win, BetPoint = 20 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-1), Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", StartTime = TimeSpan.Parse("21:00"), Status = (int)StatusMatchEnum.IsKicking, TypeGuess = (int)TypeGuessEnum.Draw, Channel = "ic_kplus.png", BetPoint = 20 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-1), Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel = "ic_kplus.png", StartTime = TimeSpan.Parse("07:00"), Status = (int)StatusMatchEnum.NotStart, TypeGuess = (int)TypeGuessEnum.Team2Win, BetPoint = 20 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-2), Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel = "ic_kplus.png", StartTime = TimeSpan.Parse("09:00"), Status = (int)StatusMatchEnum.NotStart, TypeGuess = (int)TypeGuessEnum.Team1Win, BetPoint = 80 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-2), Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel = "ic_espn.png", StartTime = TimeSpan.Parse("13:00"), Status = (int)StatusMatchEnum.NotStart, TypeGuess = (int)TypeGuessEnum.Draw, BetPoint = 80 });
            historyMatch.Add(new MatchHistory() { PlayDate = DateTime.Now.AddDays(-2), Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", StartTime = TimeSpan.Parse("15:00"), Status = (int)StatusMatchEnum.NotStart, Channel = "ic_kplus.png", TypeGuess = (int)TypeGuessEnum.Team2Win, BetPoint = 20 });
        }
    }
}
