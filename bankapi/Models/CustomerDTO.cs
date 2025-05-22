namespace bankapi.Models
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Givenname { get; set; }
        public string Surname { get; set; }
        public List<AccountDTO> Accounts { get; set; }
    }
}