
using DutyModels;

namespace DutyBusinessLayer
{
    public interface IDutyService
    {
        public Task<Duty> GetById(int id);
        public Task<List<Duty>> GetDuties();
        public Task Add(Duty d);
        public Task Update(Duty d);
        public Task Remove(Duty d);
    }
}
