using DutyDatabaseLayer;
using DutyModels;

namespace DutyBusinessLayer
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _repository;

        public TeamService(ITeamRepository repository)
        {
            _repository = repository;
        }

        public async Task<Team> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<Team>> GetTeams()
        {
            return await _repository.GetTeams();
        }

        public async Task Update(Team t)
        {
            await _repository.Update(t);
        }

        public async Task Remove(Team t)
        {
            await _repository.Remove(t);
        }

        public async Task Add(Team t)
        {
            await _repository.Add(t);
        }
    }
}
