using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SoccerBetting.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeResponse response { get; set; } = new HomeResponse();

        public Color ColorTime { get; set; } = Color.White;

        public HomeViewModel()
        {
            setData();
        }

        public void setData()
        {
            var listOfMatch = new List<MatchList>();

            var team1 = new Team { Id = 1, ShortName = "GER", Name = "Germany", Image = "ger.png" };
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

            //Ads
            var dtCarousel = new List<Ads>();
            dtCarousel.Add(new Ads { Id = 1, Image = "img3.jpg" });
            dtCarousel.Add(new Ads { Id = 2, Image = "img2.jpg" });
            dtCarousel.Add(new Ads { Id = 3, Image = "img1.jpg" });
            dtCarousel.Add(new Ads { Id = 4, Image = "img4.jpg" });
            response.listAds = dtCarousel;

            //News
            var dtNew = new List<New>();
            dtNew.Add(new New { Id = 1, Title = "A hot match for weekly !!!", Image = "ic_ball.png" });
            dtNew.Add(new New { Id = 2, Title = "Critiano Ronaldo has hat-trich with Spain in third-match in 2019", Image = "ic_ball.png" });
            dtNew.Add(new New { Id = 3, Title = "England will not have Roooney in first match in Euro 2020", Image = "ic_ball.png" });
            dtNew.Add(new New { Id = 4, Title = "IS War is dangerous for stadium in European when celebrate soccer's league", Image = "ic_ball.png" });
            dtNew.Add(new New { Id = 5, Title = "Germany will host Euro 2022", Image = "ic_ball.png" });
            response.listNew = dtNew;

            // Rank Table
            var listOfTableResultList = new List<TableResultList>();

            var tblResultLists = new TableResultList()
            {
                new TableResult { Position = 1, Team = team1, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team2, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team1, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team2, MatchKicked = 3, Point = 1, WLIndex = "1-8" }
            };
            tblResultLists.TableName = "A";
            listOfTableResultList.Add(tblResultLists);

            var tblResultLists2 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team1, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team2, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team1, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team2, MatchKicked = 3, Point = 1, WLIndex = "1-9" }
            };
            tblResultLists2.TableName = "B";
            listOfTableResultList.Add(tblResultLists2);

            var tblResultLists3 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team1, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team2, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team1, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team2, MatchKicked = 3, Point = 1, WLIndex = "1-10" }
            };
            tblResultLists3.TableName = "C";
            listOfTableResultList.Add(tblResultLists3);

            var tblResultLists4 = new TableResultList()
            {
                new TableResult { Position = 1, Team = team1, MatchKicked = 3, Point = 9, WLIndex = "6-6" },
                new TableResult { Position = 2, Team = team2, MatchKicked = 3, Point = 6, WLIndex = "5-6" },
                new TableResult { Position = 3, Team = team1, MatchKicked = 3, Point = 3, WLIndex = "4-1" },
                new TableResult { Position = 4, Team = team2, MatchKicked = 3, Point = 1, WLIndex = "1-11" }
            };
            tblResultLists4.TableName = "D";
            listOfTableResultList.Add(tblResultLists4);

            response.listOfTeamRank = listOfTableResultList;
        }
    }
}
