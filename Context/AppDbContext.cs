using finance_control.Models;
using Microsoft.EntityFrameworkCore;

namespace finance_control.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

}