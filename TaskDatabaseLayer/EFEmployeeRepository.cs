using DutyModels;
using DutyDbLibrary;

namespace DutyDatabaseLayer
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private DutyContext context;

        public EFEmployeeRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
