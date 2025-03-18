

namespace FCArena.Module.Turnament.Core.Entity
{
    public class Match
    {
    public int Id { get; set; }
    public int TournamentId { get; set; }
    public Tournament? Tournament { get; set; }
    public int Player1Id { get; set; }
    public int Player2Id { get; set; }
    public string? FinalScore { get; set; } // საბოლოო ანგარიში (მაგ: "3-2")
    public int WinnerId { get; set; } // გამარჯვებული მოთამაშე
    public DateTime MatchDate { get; set; }
    }
}