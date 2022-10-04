namespace DutyModels
{
    public class Duty : FullAudit
    {
        public string Description { get; set; } = string.Empty;

        public DateTime Due { get; set; }

        public Employee? Assigned { get; set; }

        public bool Completed { get; set; }
    }
}
