using CaseDesk.Domain.Common.Interfaces;

namespace CaseDesk.Domain.Common.Entities;

public abstract class AuditableEntity : BaseEntity, IAuditableEntity, ISoftDeletable
{
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }

    public Guid? CreatedByUserId { get; set; }
    public Guid? UpdatedByUserId { get; set; }

    public bool IsDeleted { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
    public Guid? DeletedByUserId { get; set; }
}
