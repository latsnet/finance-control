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

}