
namespace FCArena.Module.UserProfile.Core.Entity
{
    public class UserProfile
    {


        public int Id { get; set; }
        public int UserId { get; set; }
        public string? AvatarUrl { get; set; } 
        public int Rating { get; set; } = 0; 
        public List<MatchResulthistory> LastMatches { get; set; } = new List<MatchResulthistory>(); 
        public List<Badge> Badges { get; set; } = new List<Badge>(); 
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

   
}