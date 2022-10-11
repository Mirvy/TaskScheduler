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

        public async Task Update(Team t)
        {
            context.Teams.Update(t);
            await context.SaveChangesAsync();
        }

        public async Task Remove(Team t)
        {
            context.Teams.Remove(t);
            await context.SaveChangesAsync();
        }

        public async Task Add(Team t)
        {
            context.Teams.Add(t);
            await context.SaveChangesAsync();
        }
    }
}
