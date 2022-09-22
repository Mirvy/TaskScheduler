namespace TaskScheduler.Models
{
    public class Task
    {
        public long? TaskID { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime Created { get; set; }

        public DateTime Due { get; set; }

        public Employee? Assigned { get; set; }

        public bool Completed { get; set; }
    }
}
