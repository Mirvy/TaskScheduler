namespace TaskScheduler.Models
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private DataContext context;

        public EFEmployeeRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
