

namespace FCArena.Module.Payments.Core.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

public enum TransactionType
{
    Deposit,
    TournamentFee
}