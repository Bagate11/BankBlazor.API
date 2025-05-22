namespace bankapi.Models
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public decimal Balance { get; set; }
        public string? AccountHolderName { get; set; }
    }
}
