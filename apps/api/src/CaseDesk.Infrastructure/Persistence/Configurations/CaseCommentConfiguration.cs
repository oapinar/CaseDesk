using CaseDesk.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaseDesk.Infrastructure.Persistence.Configurations;

public class CaseCommentConfiguration : IEntityTypeConfiguration<CaseComment>
{
    public void Configure(EntityTypeBuilder<CaseComment> builder)
    {
        builder.ToTable("case_comments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Body)
            .IsRequired()
            .HasMaxLength(4000);

        builder.Property(x => x.IsInternal)
            .IsRequired();

        builder.HasIndex(x => x.CaseId);
        builder.HasIndex(x => x.AuthorUserId);
    }
}
