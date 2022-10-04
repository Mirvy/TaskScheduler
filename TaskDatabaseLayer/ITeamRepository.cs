using DutyModels;

namespace DutyDatabaseLayer
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
