namespace TaskScheduler.Models
{
    public class EFProjectRepository : IProjectRepository
    {
        private DataContext context;

        public EFProjectRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Project> Projects => context.Projects;
    }
}
