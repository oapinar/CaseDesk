using CaseDesk.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseDesk.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Case> Cases => Set<Case>();
    public DbSet<CaseComment> CaseComments => Set<CaseComment>();
    public DbSet<CaseTask> CaseTasks => Set<CaseTask>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("casedesk");

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
