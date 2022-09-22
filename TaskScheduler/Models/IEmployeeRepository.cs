namespace TaskScheduler.Models
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
