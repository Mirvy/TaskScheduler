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
            return await context.Employees
                .Include(e => e.Team)
                .Include(e => e.Duties)
                .ToListAsync();
        }

        public async Task Update(Employee e)
        {
            context.Update(e);
            await context.SaveChangesAsync();
        }

        public async Task Remove(Employee e)
        {
            context.Remove(e);
            await context.SaveChangesAsync();
        }

        public async Task Add(Employee e)
        {
            context.Add(e);
            await context.SaveChangesAsync();
        }
    }
}
