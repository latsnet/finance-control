using Microsoft.EntityFrameworkCore;

namespace finance_control.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }

}