using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IEmployeeRepository
    {
        public Task<Employee> GetById(int id);
        public Task<List<Employee>> GetEmployees();
        public Task Update(Employee e);
        public Task Remove(Employee e);
        public Task Add(Employee e);
    }
}
