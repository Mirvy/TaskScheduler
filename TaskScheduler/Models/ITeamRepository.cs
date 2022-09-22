namespace TaskScheduler.Models
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
