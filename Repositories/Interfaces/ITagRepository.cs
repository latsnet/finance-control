using finance_control.Models;

namespace finance_control.Repositories.Interfaces;

public interface ITagRepository
{
    IEnumerable<Tag> Tags { get; }

}