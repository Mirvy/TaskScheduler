using DutyModels;
using DutyDbLibrary;

namespace DutyDatabaseLayer
{
    public class EFProjectRepository : IProjectRepository
    {
        private DutyContext context;

        public EFProjectRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Project> Projects => context.Projects;
    }
}
