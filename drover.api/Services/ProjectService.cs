using Drover.Api.Factories;
using Drover.Contracts.Projects;

namespace Drover.Api.Services
{
    public class ProjectService : BaseService, IProjectService
    {
        public ProjectService(IBugherdConnection connection) : base(connection)
        {
        }

        public async Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests)
        {
            var service = CreateBugherdApi();

            var request = new CreateProjectRequest {
                GuestsSeeGuests = guestsSeeGuests,
                IsActive = isActive,
                IsPublic = isPublic,
                Name = name,
                WebsiteUrl = websiteUrl
            };

            var response = await service.CreateProject(request);
        }

        public async Task<List<Project>> GetActiveProjects(int? page)
        {
            var service = CreateBugherdApi();

            var request = new ProjectsRequest { Page = page };

            var response = await service.GetActiveProjects(request);

            return response.Projects;
        }

        public async Task<Project> GetProject(int id)
        {
            var service = CreateBugherdApi();

            var request = new SingleProjectRequest { Id = id };

            var response = await service.GetProject(request);

            return response.Project;
        }

        public async Task<List<Project>> GetProjects(int? page)
        {
            var service = CreateBugherdApi();

            var request = new ProjectsRequest { Page = page };

            var response = await service.GetProjects(request);

            return response.Projects;
        }
    }
}