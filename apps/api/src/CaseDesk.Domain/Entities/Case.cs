using CaseDesk.Domain.Common.Entities;
using CaseDesk.Domain.Enums;

namespace CaseDesk.Domain.Entities;

public class Case : AuditableEntity
{
    public Guid ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public CaseStatus Status { get; set; } = CaseStatus.Open;
    public CasePriority Priority { get; set; } = CasePriority.Medium;

    public DateTime OpenedAtUtc { get; set; }
    public DateTime? ClosedAtUtc { get; set; }

    public Guid? AssignedUserId { get; set; }

    public ICollection<CaseComment> Comments { get; set; } = new List<CaseComment>();
    public ICollection<CaseTask> Tasks { get; set; } = new List<CaseTask>();
}
