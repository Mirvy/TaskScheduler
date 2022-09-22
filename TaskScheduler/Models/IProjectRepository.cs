namespace TaskScheduler.Models
{
    public interface IProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
