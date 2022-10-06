using DutyDatabaseLayer;
using DutyModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DutyBusinessLayer
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repository;

        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<Project> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _repository.GetProjects();
        }
    }
}
