using DutyModels;
using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;

namespace DutyDatabaseLayer
{
    public class EFDutyRepository : IDutyRepository
    {
        private DutyContext context;

        public EFDutyRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public async Task<Duty> GetById(int id)
        {
            return await context.Duties
                .Include(d => d.Assigned)
                .Include(d => d.Project)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<List<Duty>> GetDuties()
        {
            return await context.Duties
                .Include(d => d.Assigned)
                .Include(d => d.Project)
                .ToListAsync();
        }

        public async Task Add(Duty d)
        {
            await context.AddAsync(d);
            await context.SaveChangesAsync();
        }

        public async Task Update(Duty d)
        {
            context.Update(d);
            await context.SaveChangesAsync();
        }

        public async Task Remove(Duty d)
        {
            context.Remove(d);
            await context.SaveChangesAsync();
        }

    }
}
