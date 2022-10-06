using DutyModels;


namespace DutyBusinessLayer
{
    public interface IProjectService
    {
        Task<Project> GetById(int id);
        Task<List<Project>> GetProjects();
    }
}
