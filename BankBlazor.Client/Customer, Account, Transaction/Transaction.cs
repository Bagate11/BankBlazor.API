using System.Security.Principal;

namespace BankBlazor.Client.Customer__Account__Transaction
{
    public enum TransactionType { Deposit, Withdrawal, Transfer }
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account? Account { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int? RelatedAccountId { get; set; }
    }
}
//e