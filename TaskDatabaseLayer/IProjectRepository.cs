using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
