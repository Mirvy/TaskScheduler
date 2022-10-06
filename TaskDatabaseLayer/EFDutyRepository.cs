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
            return await context.Duties.FindAsync(id);
        }

        public async Task<List<Duty>> GetDuties()
        {
            return await context.Duties.ToListAsync();
        }

    }
}
