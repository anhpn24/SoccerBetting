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

            var team1 = new Team { Id = 1, Name = "VietNam", Image = "vn.png" };
            var team2 = new Team { Id = 2, Name = "Japan", Image = "jp.png" };

            var match1 = new MatchList()
            {
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="K+", Status=(int)StatusMatchEnum.Finished , TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=60, ScoreTeam1=5, ScoreTeam2=1 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="K+", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Draw, BetPoint=100, ScoreTeam1=3, ScoreTeam2=3 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ESPN", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=80, ScoreTeam1=1, ScoreTeam2=7 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge", Channel="K+", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=30, ScoreTeam1=3, ScoreTeam2=3 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Santiago Bernabéu", Channel="ESPN", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=50, ScoreTeam1=0, ScoreTeam2=3 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Camp Nou", Channel="K+", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=120, ScoreTeam1=5, ScoreTeam2=1 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Allianz Arena", Channel="K+", Status=(int)StatusMatchEnum.Finished, TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=150, ScoreTeam1=3, ScoreTeam2=3 }
            };
            match1.PlayDate = DateTime.Now.AddDays(-1);
            listOfMatch.Add(match1);

            var match2 = new MatchList()
            {
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="K+", Status=(int)StatusMatchEnum.Finished, ScoreTeam1=1, ScoreTeam2=2 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="K+", Status=(int)StatusMatchEnum.Finished, ScoreTeam1=0, ScoreTeam2=0 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ESPN", Status=(int)StatusMatchEnum.NotStart, TypeGuess=(int)TypeGuessEnum.Team2Win, BetPoint=20 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge",Status=(int)StatusMatchEnum.IsKicking, Channel="K+" }
            };
            match2.PlayDate = DateTime.Now;
            listOfMatch.Add(match2);

            var match3 = new MatchList()
            {
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Emirates", Channel="K+", Status=(int)StatusMatchEnum.NotStart },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Old Tranford", Channel="K+",Status=(int)StatusMatchEnum.NotStart , TypeGuess=(int)TypeGuessEnum.Team1Win, BetPoint=80 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Anfield", Channel="ESPN",Status=(int)StatusMatchEnum.NotStart , TypeGuess=(int)TypeGuessEnum.Draw, BetPoint=80 },
                new Match() { Team1 = team1, Team2 = team2, Stadium = "Stamford Bridge",Status=(int)StatusMatchEnum.NotStart , Channel="K+" }
            };
            match3.PlayDate = DateTime.Now.AddDays(2);
            listOfMatch.Add(match3);

            response.listOfMatch = listOfMatch;
        }
    }
}
