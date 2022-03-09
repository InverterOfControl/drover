using Drover.Contracts.Projects;

namespace Drover.Api.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects(int? page);

        Task<List<Project>> GetActiveProjects(int? page);

        Task<Project> GetProject(int id);

        Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests);
    }
}
