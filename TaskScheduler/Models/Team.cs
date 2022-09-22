namespace TaskScheduler.Models
{
    public class Team
    {
        public long? TeamID { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();

        public IEnumerable<Project> Projects { get; set; } = Enumerable.Empty<Project>();
    }
}
