namespace TaskScheduler.Models
{
    public class EFTeamRepository : ITeamRepository
    {
        private DataContext context;

        public EFTeamRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Team> Teams => context.Teams;
    }
}
