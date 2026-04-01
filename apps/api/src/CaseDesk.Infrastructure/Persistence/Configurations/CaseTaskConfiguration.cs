using CaseDesk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaseDesk.Infrastructure.Persistence.Configurations;

public class CaseTaskConfiguration : IEntityTypeConfiguration<CaseTask>
{
    public void Configure(EntityTypeBuilder<CaseTask> builder)
    {
        builder.ToTable("case_tasks");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Description)
            .HasMaxLength(2000);

        builder.Property(x => x.Status)
            .IsRequired();

        builder.HasIndex(x => x.CaseId);
        builder.HasIndex(x => x.AssignedUserId);
        builder.HasIndex(x => x.Status);
    }
}
