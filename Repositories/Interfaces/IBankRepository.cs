using finance_control.Models;

namespace finance_control.Repositories.Interfaces;

public interface IBankRepository
{
    IEnumerable<Bank> Banks { get; }

}