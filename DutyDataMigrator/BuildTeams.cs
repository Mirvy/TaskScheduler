using DutyDbLibrary;
using DutyModels;

namespace DutyDataMigrator
{
    internal class BuildTeams
    {
        private readonly DutyContext _context;

        public BuildTeams(DutyContext context)
        {
            _context = context;
        }

        public void ExecuteSeed()
        {
            if (_context.Teams.Count() == 0)
            {
                _context.AddRange(
                    new Team()
                    {
                        Name = SeedDataConstants.TEAM01_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Team()
                    {
                        Name = SeedDataConstants.TEAM02_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Team()
                    {
                        Name = SeedDataConstants.TEAM03_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Team()
                    {
                        Name = SeedDataConstants.TEAM04_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Team()
                    {
                        Name = SeedDataConstants.TEAM05_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    }
                    );
                _context.SaveChanges();
            }
        }
    }
}
