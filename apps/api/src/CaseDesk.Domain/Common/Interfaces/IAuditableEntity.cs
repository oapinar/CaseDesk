namespace CaseDesk.Domain.Common.Interfaces;

public interface IAuditableEntity
{
    DateTime CreatedAtUtc { get; set; }
    DateTime? UpdatedAtUtc { get; set; }

    Guid? CreatedByUserId { get; set; }
    Guid? UpdatedByUserId { get; set; }
}
