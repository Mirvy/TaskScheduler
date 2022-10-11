using DutyModels;

namespace DutyDatabaseLayer
{
    public interface IProjectRepository
    {
        public Task<Project> GetById(int id);
        public Task<List<Project>> GetProjects();
        public Task Update(Project p);

        public Task Remove(Project p);

        public Task Add(Project p);

    }
}
