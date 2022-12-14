using System.ComponentModel.DataAnnotations;

namespace DutyModels
{
    public class Duty : FullAudit
    {
        public string Description { get; set; } = string.Empty;

        public DateTime Due { get; set; } = DateTime.Now;

        public int? AssignedId { get; set; }
        public virtual Employee? Assigned { get; set; }

        public int? ProjectId { get; set; }
        public virtual Project? Project { get; set; }

        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"ID:{Id} | Description:{Description} | CreatedById:{CreatedById} | AssignedById:{AssignedId}";
        }
    }
}
