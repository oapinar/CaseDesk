using CaseDesk.Domain.Common.Entities;
using CaseDesk.Domain.Enums;

namespace CaseDesk.Domain.Entities;

public class CaseTask : AuditableEntity
{
    public Guid CaseId { get; set; }
    public Case Case { get; set; } = null!;

    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }

    public CaseTaskStatus Status { get; set; } = CaseTaskStatus.ToDo;
    public DateTime? DueAtUtc { get; set; }

    public Guid? AssignedUserId { get; set; }
}
