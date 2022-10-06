
using DutyDbLibrary;
using DutyModels;

namespace DutyDataMigrator
{
    internal class BuildDuties
    {
        private readonly DutyContext _context;
        public BuildDuties(DutyContext context)
        {
            _context = context;
        }

        public void ExecuteSeed()
        {
            if(_context.Duties.Count() == 0)
            {
                _context.Duties.AddRange(
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY01_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY02_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY03_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY04_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY05_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY06_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY07_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY08_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY09_DESCRIPTION,
                        Due = DateTime.Now.AddYears(1),
                        Assigned = null,
                        Completed = false,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Duty()
                    {
                        Description = SeedDataConstants.DUTY10_DESCRIPTION,
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
