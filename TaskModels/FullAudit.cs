using DutyModels.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DutyModels
{
    public abstract class FullAudit : IIdentity, IAudited, IActivatable, ISoftDeletable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CreatedById { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
