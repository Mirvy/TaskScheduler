using DutyDatabaseLayer;
using DutyModels;
using Microsoft.EntityFrameworkCore;

namespace DutyBusinessLayer
{
    public class DutyService : IDutyService
    {
        private IDutyRepository _repository;

        public DutyService(IDutyRepository dutyRepository)
        {
            _repository = dutyRepository;
        }

        public async Task<Duty> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<Duty>> GetDuties()
        {
            return await _repository.GetDuties();
        }
        
        public async Task Add(Duty d)
        {
            await _repository.Add(d);
        }

        public async Task Update(Duty d)
        {
            await _repository.Update(d);
        }

        public async Task Remove(Duty d)
        {
            await _repository.Remove(d);
        }
    }
}
