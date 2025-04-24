using System.Transactions;

namespace BankBlazor.Client.Customer__Account__Transaction
{
    public class Account
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Transaction> Transactions { get; set; } = new();
    }
}
