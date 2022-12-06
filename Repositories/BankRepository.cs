using finance_control.Context;
using finance_control.Models;
using finance_control.Repositories.Interfaces;

namespace finance_control.Repositories;

public class BankRepository : IBankRepository
{

    private readonly AppDbContext _context;

    public BankRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Bank> Banks { get; }
    
}