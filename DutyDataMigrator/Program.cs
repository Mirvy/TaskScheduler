using DutyDbLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DutyDataMigrator
{
    public static class DutyDataMigrator
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<DutyContext> _optionsBuilder;

        public static void Main(string[] args)
        {
            BuildOptions();
            ApplyMigrations();
            ExecuteCustomSeedData();
        }

        private static void BuildOptions()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
            _optionsBuilder = new DbContextOptionsBuilder<DutyContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DutySchedulerConnection"));
        }

        private static void ApplyMigrations()
        {
            using var db = new DutyContext(_optionsBuilder.Options);
            db.Database.Migrate();
        }

        private static void ExecuteCustomSeedData()
        {
            using var context = new DutyContext(_optionsBuilder.Options);
            var duties = new BuildDuties(context);
            duties.ExecuteSeed();
            var employees = new BuildEmployees(context);
            employees.ExecuteSeed();
            var projects = new BuildProjects(context);
            projects.ExecuteSeed();
            var teams = new BuildTeams(context);
            teams.ExecuteSeed();
        }
    }

}
