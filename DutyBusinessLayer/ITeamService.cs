using DutyModels;

namespace DutyBusinessLayer
{
    public interface ITeamService
    {
        Task<List<Team>> GetTeams();
    }
}
