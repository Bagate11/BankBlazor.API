using System.Security.Principal;

namespace BankBlazor.Client.Customer__Account__Transaction
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Account> Accounts { get; set; } = new();
    }
}
