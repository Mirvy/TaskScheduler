namespace DutyModels
{
    public class Employee: FullAudit
    {
        public string Name { get; set; } = string.Empty;

        public Team? Team { get; set; }

        public IEnumerable<Duty> Duties { get; set; } = Enumerable.Empty<Duty>();
    }
}
