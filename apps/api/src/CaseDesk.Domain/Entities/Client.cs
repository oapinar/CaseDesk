using CaseDesk.Domain.Common.Entities;

namespace CaseDesk.Domain.Entities;

public class Client : AuditableEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }

    public ICollection<Case> Cases { get; set; } = new List<Case>();
}
