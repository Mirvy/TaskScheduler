using DutyModels;
using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;

namespace DutyDatabaseLayer
{
    public class EFTeamRepository : ITeamRepository
    {
        private DutyContext context;

        public EFTeamRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public async Task<Team> GetById(int id)
        {
            return await context.Teams.FindAsync(id);
        }

        public async Task<List<Team>> GetTeams()
        {
            return await context.Teams.ToListAsync();
        }
    }
}
