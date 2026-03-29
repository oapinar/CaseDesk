using CaseDesk.Domain.Common.Entities;

namespace CaseDesk.Domain.Entities;

public class CaseComment : AuditableEntity
{
    public Guid CaseId { get; set; }
    public Case Case { get; set; } = null!;

    public Guid AuthorUserId { get; set; }

    public string Body { get; set; } = string.Empty;
    public bool IsInternal { get; set; }
}
