using BankBlazor.Client.Customer__Account__Transaction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BankBlazor.Client.DB
{
    public class BankContext : DbContext 
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options) { }
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Transaction> Transactions => Set<Transaction>();
    }

}
