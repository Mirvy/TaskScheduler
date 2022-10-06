using DutyDbLibrary;
using DutyModels;

namespace DutyDataMigrator
{
    internal class BuildProjects
    {
        private readonly DutyContext _context;

        public BuildProjects(DutyContext context)
        {
            _context = context;
        }

        public void ExecuteSeed()
        {
            if (_context.Projects.Count() == 0)
            {
                _context.AddRange(
                    new Project()
                    {
                        Description = SeedDataConstants.PROJECT01_NAME,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Project()
                    {
                        Description = SeedDataConstants.PROJECT02_NAME,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Project()
                    {
                        Description = SeedDataConstants.PROJECT03_NAME,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Project()
                    {
                        Description = SeedDataConstants.PROJECT04_NAME,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Project()
                    {
                        Description = SeedDataConstants.PROJECT05_NAME,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
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
