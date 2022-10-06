
using DutyModels;

namespace DutyBusinessLayer
{
    public interface IDutyService
    {
        public Task<Duty> GetById(int id);
        public Task<List<Duty>> GetDuties();
    }
}
