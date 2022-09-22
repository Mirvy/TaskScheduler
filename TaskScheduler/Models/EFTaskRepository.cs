namespace TaskScheduler.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private DataContext context;

        public EFTaskRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Task> Tasks => context.Tasks;

    }
}
