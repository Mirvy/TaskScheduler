using DutyDatabaseLayer;
using DutyModels;

namespace DutyBusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task Update(Employee e)
        {
            await _employeeRepository.Update(e);
        }

        public async Task Remove(Employee e)
        {
            await _employeeRepository.Remove(e);
        }

        public async Task Add(Employee e)
        {
            await _employeeRepository.Add(e);
        }
    }
}