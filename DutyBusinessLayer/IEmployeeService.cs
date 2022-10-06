using DutyModels;

namespace DutyBusinessLayer
{
    public interface IEmployeeService
    {
        public Task<Employee> GetById(int id);
        public Task<List<Employee>> GetEmployees();
    }
}
