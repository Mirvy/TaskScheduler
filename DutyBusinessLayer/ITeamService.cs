using DutyModels;

namespace DutyBusinessLayer
{
    public interface ITeamService
    {
        Task<Team> GetById(int id);
        Task<List<Team>> GetTeams();

        Task Update(Team t);

        Task Remove(Team t);

        Task Add(Team t);
    }
}
