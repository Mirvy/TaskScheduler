using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IProjectRepository
    {
        public Task<Project> GetById(int id);
        public Task<List<Project>> GetProjects();
    }
}
