
namespace FCArena.Module.UserProfile.Core.Entity
{
    public class MatchResulthistory
    {
         public int Id { get; set; }
        public string? OpponentUsername { get; set; } 
        public string? Result { get; set; }
        public string? FinalScore { get; set; } 
        public int GoalsScored { get; set; } 
        public int Assists { get; set; } 
        public DateTime MatchDate { get; set; }
    }
}