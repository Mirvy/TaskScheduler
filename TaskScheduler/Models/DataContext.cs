using Microsoft.EntityFrameworkCore;

namespace TaskScheduler.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Team> Teams => Set<Team>();

        public DbSet<Project> Projects => Set<Project>();

        public DbSet<Task> Tasks => Set<Task>();

    }
}
