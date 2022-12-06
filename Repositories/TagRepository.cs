using finance_control.Context;
using finance_control.Models;
using finance_control.Repositories.Interfaces;

namespace finance_control.Repositories;

public class TagRepository : ITagRepository
{

    private readonly AppDbContext _context;

    public TagRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Tag> Tags => _context.Tags;

}