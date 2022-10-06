using DutyDbLibrary;
using DutyModels;

namespace DutyDataMigrator
{
    internal class BuildEmployees
    {
        private readonly DutyContext _context;

        public BuildEmployees(DutyContext context)
        {
            _context = context;
        }

        public void ExecuteSeed()
        {
            if (_context.Employees.Count() == 0)
            {
                _context.AddRange(
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE01_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE02_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE03_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE04_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE05_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE06_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE07_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE08_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE09_NAME,
                        CreatedById = SeedDataConstants.SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false
                    },
                    new Employee()
                    {
                        Name = SeedDataConstants.EMPLOYEE10_NAME,
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
