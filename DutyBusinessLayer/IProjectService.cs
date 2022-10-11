using DutyModels;


namespace DutyBusinessLayer
{
    public interface IProjectService
    {
        Task<Project> GetById(int id);
        Task<List<Project>> GetProjects();

        Task Update(Project p);

        Task Remove(Project p);
        Task Add(Project p);
    }
}
