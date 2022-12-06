using finance_control.Models;
using finance_control.Repositories.Interfaces;

namespace finance_control.Repositories;

public class CategoryRepository : ICategoryRepository
{
    IEnumerable<Category> ICategoryRepository.Categories => throw new NotImplementedException();
}