namespace TaskScheduler.Models
{
    public interface ITaskRepository
    {
        IQueryable<Task> Tasks { get; }
    }
}
