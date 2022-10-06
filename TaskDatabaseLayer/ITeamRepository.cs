using DutyModels;

namespace DutyDatabaseLayer
{
    public interface ITeamRepository
    {
        public Task<Team> GetById(int id);
        public Task<List<Team>> GetTeams();
    }
}
