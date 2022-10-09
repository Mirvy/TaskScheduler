namespace DutyModels
{
    public class Team : FullAudit
    {
        public string Name { get; set; } = string.Empty;

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();

        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
