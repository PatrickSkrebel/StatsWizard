using System.Collections.Generic;

namespace StatsWizard.Models
{
    public class StandingsModel
    {
        public League League { get; set; }
        public Season Season { get; set; }
        public List<Conference> Conferences { get; set; }
    }

    public class League
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
    }

    public class Season
    {
        public string Id { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }

    public class Conference
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public List<Division> Divisions { get; set; }
    }

    public class Division
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public List<Team> Teams { get; set; }
    }

    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double Win_Pct { get; set; }
        public double PointsFor { get; set; }
        public double PointsAgainst { get; set; }
        public double PointDiff { get; set; }
        public string SrId { get; set; }
        public string Reference { get; set; }
        public GamesBehind GamesBehind { get; set; }
        public Streak Streak { get; set; }
        public CalcRank Calc_Rank { get; set; }
    }

    public class GamesBehind
    {
        public int League { get; set; }
        public int Conference { get; set; }
        public int Division { get; set; }
    }

    public class Streak
    {
        public string Kind { get; set; }
        public int Length { get; set; }
    }

    public class CalcRank
    {
        public int Div_Rank { get; set; }
        public int Conf_Rank { get; set; }
    }
}
