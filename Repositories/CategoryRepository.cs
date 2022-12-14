using finance_control.Context;
using finance_control.Models;
using finance_control.Repositories.Interfaces;

namespace finance_control.Repositories;

public class CategoryRepository : ICategoryRepository
{

    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        this._context = context;
    }

    public IEnumerable<Category> Categories => _context.Categories;
    
}