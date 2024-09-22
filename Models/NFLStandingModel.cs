namespace StatsWizard.Models.NFL
{
    public class NFLStandingModel
    {
        public Season Season { get; set; }
        public List<Conference> Conferences { get; set; }
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
        public List<Team> Teams { get; set; }
    }

    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public double Win_Pct { get; set; }
        public CalcRank Rank { get; set; }
        public Streak Streak { get; set; }

        // Changed to hold a list of records instead of a single record
        public List<Record> Records { get; set; }
    }

    public class CalcRank
    {
        public int Conference { get; set; }
        public int Division { get; set; }
    }

    public class Streak
    {
        public string Type { get; set; }
        public int Length { get; set; }
        public string Desc { get; set; }
    }

    public class Record
    {
        public string Category { get; set; }  // Fixed typo: "Catergory" to "Category"

        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public double Win_Pct { get; set; } // Optional: Include win percentage if needed
        public int Points_For { get; set; }
        public int Points_Against { get; set; }
    }
}
