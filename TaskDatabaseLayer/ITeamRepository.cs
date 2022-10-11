using DutyModels;

namespace DutyDatabaseLayer
{
    public interface ITeamRepository
    {
        public Task<Team> GetById(int id);
        public Task<List<Team>> GetTeams();
        public Task Update(Team t);

        public Task Remove(Team t);
        public Task Add(Team t);
    }
}
