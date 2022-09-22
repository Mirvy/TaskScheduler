namespace TaskScheduler.Models
{
    public class Employee
    {
        public long? EmployeeID { get; set; }

        public string Name { get; set; } = string.Empty;

        public Team? Team { get; set; }

        public IEnumerable<Task> Tasks { get; set; } = Enumerable.Empty<Task>();
    }
}
