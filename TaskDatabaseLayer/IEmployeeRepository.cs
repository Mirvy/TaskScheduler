using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IEmployeeRepository
    {
        public Task<Employee> GetById(int id);
        public Task<List<Employee>> GetEmployees();
    }
}
