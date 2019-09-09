using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class LatestViewModel : BaseViewModel
    {
        public LatestResponse response { get; set; } = new LatestResponse();
        public LatestViewModel()
        {
            setData();
        }        

        public void setData()
        {            
            var listOfMatch = new List<MatchList>();

            var team1 = new Team { Id = 1, ShortName="GER", Name = "Germany", Image = "ger.png" };
            var team2 = new Team { Id = 2, ShortName = "FRA", Name = "France", Image = "fra.png" };

            var match1 = new MatchList()
            {
                new Match() { Id = 1, Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("07:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=60, ScoreTeam1=5, ScoreTeam2=1 },
                new Match() { Id = 2, Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("08:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Draw, BetPoint=100, ScoreTeam1=3, ScoreTeam2=3 },
                new Match() { Id = 3, Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ic_espn.png", StartTime= TimeSpan.Parse("09:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=80, ScoreTeam1=1, ScoreTeam2=7 },
                new Match() { Id = 4, Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("10:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=30, ScoreTeam1=3, ScoreTeam2=3 },
                new Match() { Id = 5, Team1 = team1, Team2 = team2, Stadium = "Santiago Bernabéu", Channel="ic_espn.png", StartTime= TimeSpan.Parse("11:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=50, ScoreTeam1=0, ScoreTeam2=3 },
                new Match() { Id = 6, Team1 = team1, Team2 = team2, Stadium = "Camp Nou", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("12:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=120, ScoreTeam1=5, ScoreTeam2=1 },
                new Match() { Id = 7, Team1 = team1, Team2 = team2, Stadium = "Allianz Arena", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("13:00"), Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=150, ScoreTeam1=3, ScoreTeam2=3 }
            };
            match1.PlayDate = DateTime.Now.AddDays(-1);
            listOfMatch.Add(match1);

            var match2 = new MatchList()
            {
                new Match() { Id = 8, Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("07:00"), Status=(int)StatusMatchEnum.Finished, ScoreTeam1=1, ScoreTeam2=2 },
                new Match() { Id = 9, Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("10:00"), Status=(int)StatusMatchEnum.Finished, ScoreTeam1=0, ScoreTeam2=0 },
                new Match() { Id = 10, Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ic_espn.png", StartTime= TimeSpan.Parse("18:00"), Status=(int)StatusMatchEnum.NotStart, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=20 },
                new Match() { Id = 11, Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", StartTime= TimeSpan.Parse("21:00"), Status=(int)StatusMatchEnum.IsKicking, Channel="ic_kplus.png" }
            };
            match2.PlayDate = DateTime.Now;
            listOfMatch.Add(match2);

            var match3 = new MatchList()
            {
                new Match() { Id = 12, Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("07:00"), Status=(int)StatusMatchEnum.NotStart },
                new Match() { Id = 13, Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="ic_kplus.png", StartTime= TimeSpan.Parse("09:00"), Status=(int)StatusMatchEnum.NotStart , TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=80 },
                new Match() { Id = 14, Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ic_espn.png", StartTime= TimeSpan.Parse("13:00"), Status=(int)StatusMatchEnum.NotStart , TypeGuess=(int)TypeGuessEnum.Draw, BetPoint=80 },
                new Match() { Id = 15, Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge",StartTime= TimeSpan.Parse("15:00"), Status=(int)StatusMatchEnum.NotStart , Channel="ic_kplus.png" }
            };
            match3.PlayDate = DateTime.Now.AddDays(1);
            listOfMatch.Add(match3);

            response.listOfMatch = listOfMatch;
        }
    }
}
