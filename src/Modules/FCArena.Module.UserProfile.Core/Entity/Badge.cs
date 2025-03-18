
namespace FCArena.Module.UserProfile.Core.Entity
{
    public class Badge
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } 
        public DateTime EarnedAt { get; set; } = DateTime.UtcNow; 
        
    }
}