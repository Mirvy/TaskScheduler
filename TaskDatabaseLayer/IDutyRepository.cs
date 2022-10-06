using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IDutyRepository
    {
        public Task<Duty> GetById(int id);
        public Task<List<Duty>> GetDuties();

    }
}
