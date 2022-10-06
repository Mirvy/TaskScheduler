using DutyModels;
using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;

namespace DutyDatabaseLayer
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private DutyContext context;

        public EFEmployeeRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public async Task<Employee> GetById(int id)
        {
            return await context.Employees.FindAsync(id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }
    }
}
