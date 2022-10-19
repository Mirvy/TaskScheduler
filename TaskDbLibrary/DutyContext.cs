using Microsoft.EntityFrameworkCore;
using DutyModels;

namespace DutyDbLibrary
{
    public class DutyContext : DbContext
    {
        public DutyContext(DbContextOptions<DutyContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Team> Teams => Set<Team>();

        public DbSet<Project> Projects => Set<Project>();

        public DbSet<Duty> Duties => Set<Duty>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Duty>()
                .HasOne<Employee>(d => d.Assigned)
                .WithMany(e => e.Duties)
                .HasForeignKey(e => e.AssignedId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasMany<Employee>(t => t.Employees)
                .WithOne(e => e.Team)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Project>()
                .HasMany<Duty>(p => p.Duties)
                .WithOne(d => d.Project)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasMany<Project>(t => t.Projects)
                .WithOne(p => p.Assigned)
                .HasForeignKey(p => p.AssignedId)
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
