namespace DutyModels
{
    public class Project : FullAudit
    {
        public string Description { get; set; } = string.Empty;

        public DateTime Due { get; set; } = DateTime.Now;

        public int? AssignedId { get; set; }
        public virtual Team? Assigned { get; set; }

        public virtual List<Duty> Duties { get; set; } = new List<Duty>();

        public bool Completed { get; set; }
    }
}
