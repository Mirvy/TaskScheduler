namespace DutyModels
{
    public class Project : FullAudit
    {
        public string Description { get; set; } = string.Empty;

        public DateTime Due { get; set; }

        public Team? Assigned { get; set; }

        public IEnumerable<Duty> Duties { get; set; } = Enumerable.Empty<Duty>();

        public bool Completed { get; set; }
    }
}
