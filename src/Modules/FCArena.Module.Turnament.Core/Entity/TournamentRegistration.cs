

namespace FCArena.Module.Turnament.Core.Entity
{
    public class TournamentRegistration
    {
     public int Id { get; set; }
    public int UserId { get; set; }
 
    public int TournamentId { get; set; }
    public Tournament ?Tournament { get; set; }
    public bool PaidFee { get; set; } 
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;   
    }
}