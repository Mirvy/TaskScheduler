using DutyModels;
using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace DutyDatabaseLayer
{
    public class EFProjectRepository : IProjectRepository
    {
        private DutyContext context;

        public EFProjectRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public async Task<Project> GetById(int id)
        {
            return await context.Projects
                .Include( p => p.Assigned)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Project>> GetProjects()
        {
            return await context.Projects
                .Include( p => p.Assigned)
                .ToListAsync();
        }

        public async Task Update(Project p)
        {
            context.Update(p);
            await context.SaveChangesAsync();
        }

        public async Task Remove(Project p)
        {
            context.Remove(p);
            await context.SaveChangesAsync();
        }

        public async Task Add(Project p)
        {
            context.Add(p);
            await context.SaveChangesAsync();
        }
    }
}
