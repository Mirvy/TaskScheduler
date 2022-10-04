using DutyModels;
using DutyDbLibrary;

namespace DutyDatabaseLayer
{
    public class EFTeamRepository : ITeamRepository
    {
        private DutyContext context;

        public EFTeamRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Team> Teams => context.Teams;
    }
}
