namespace DutyModels
{
    public class Employee: FullAudit
    {
        public string Name { get; set; } = string.Empty;

        public int? TeamId { get; set; }
        public Team? Team { get; set; }

        public virtual List<Duty> Duties { get; set; } = new List<Duty>();
    }
}
