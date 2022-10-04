using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
