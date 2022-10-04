
namespace DutyModels.Interfaces
{
    public interface IAudited
    {
        public string CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
