using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IDutyRepository
    {
        IQueryable<Duty> Duties { get; }
    }
}
