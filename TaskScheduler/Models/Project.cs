namespace TaskScheduler.Models
{
    public class Project
    {
        public long? ProjectID { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime Created { get; set; }

        public DateTime Due { get; set; }

        public Team? Assigned { get; set; }

        public IEnumerable<Task> Tasks { get; set; } = Enumerable.Empty<Task>();

        public bool Completed { get; set; }
    }
}
