using DutyModels;

namespace DutyBusinessLayer
{
    public interface IEmployeeService
    {
        public Task<Employee> GetById(int id);
        public Task<List<Employee>> GetEmployees();

        public Task Update(Employee e);
        public Task Remove(Employee e);
        public Task Add(Employee e);
    }
}
