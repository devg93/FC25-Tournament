
namespace FCArena.Module.Payments.Core.Entity
{
    public class PaymentMethod
    {

    public int Id { get; set; }
    public int UserId { get; set; }
    public string? CardNumber { get; set; } 
    public string? ExpiryDate { get; set; } 
    public string? CVV { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
    }
}