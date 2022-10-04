using DutyModels;
using DutyDbLibrary;

namespace DutyDatabaseLayer
{
    public class EFDutyRepository : IDutyRepository
    {
        private DutyContext context;

        public EFDutyRepository(DutyContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Duty> Duties => context.Duties;

    }
}
