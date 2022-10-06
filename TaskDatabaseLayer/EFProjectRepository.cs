using DutyModels;
using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;

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
            return await context.Projects.FindAsync(id);
        }

        public async Task<List<Project>> GetProjects()
        {
            return await context.Projects.ToListAsync();
        }
    }
}
