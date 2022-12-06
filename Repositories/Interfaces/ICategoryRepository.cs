using finance_control.Models;

namespace finance_control.Repositories.Interfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> Categories { get; }
}
