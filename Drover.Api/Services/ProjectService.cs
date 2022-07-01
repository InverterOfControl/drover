using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Projects;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public class ProjectService : BaseService, IProjectService
    {
        private readonly IProjectApi _api;

        private ILogger logger => Logging.LogProvider.GetLogger("ProjectService");

        internal ProjectService(IBugherdConnection connection) : base(connection)
        {
            _api = CreateApi<IProjectApi>();
        }

        public async Task AddGuest(long projectId, int guestId, string email, CancellationToken cancellationToken)
        {
            var request = new AddGuestRequest { Email = email, ProjectId = projectId, UserId = guestId };

            var response = await _api.AddGuest(request, cancellationToken).ConfigureAwait(false);
        }

        public async Task AddMember(long projectId, int memberId, CancellationToken cancellationToken)
        {
            var request = new AddMemberRequest { UserId = memberId, ProjectId = projectId };

            var response = await _api.AddMember(request, cancellationToken).ConfigureAwait(false);
        }

        public async Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests, CancellationToken cancellationToken)
        {
            var project = new NewProject
            {
                GuestsSeeGuests = guestsSeeGuests,
                IsActive = isActive,
                IsPublic = isPublic,
                Name = name,
                WebsiteUrl = websiteUrl
            };

            var request = new CreateProjectRequest { Project = project };

            var response = await _api.CreateProject(request, cancellationToken).ConfigureAwait(false);
        }

        public async Task<List<Project>> GetActiveProjects(int? page, CancellationToken cancellationToken)
        {
            var request = new ProjectsRequest { Page = page };

            var response = await _api.GetActiveProjects(request, cancellationToken).ConfigureAwait(false);

            return response.Projects;
        }

        public async Task<Project> GetProject(long id, CancellationToken cancellationToken)
        {
            var request = new SingleProjectRequest { Id = id };

            var response = await _api.GetProject(request, cancellationToken).ConfigureAwait(false);

            return response.Project;
        }

        public async Task<List<Project>> GetProjects(int? page, CancellationToken cancellationToken)
        {
            var request = new ProjectsRequest { Page = page };

            var response = await _api.GetProjects(request, cancellationToken).ConfigureAwait(false);

            return response.Projects;
        }

        public async Task<List<Project>> GetProjects(CancellationToken cancellationToken)
        {
            return await this.GetProjects(null, cancellationToken).ConfigureAwait(false);
        }

        public async Task DeleteProject(long projectId, CancellationToken cancellationToken)
        {
            var request = new DeleteProjectRequest { ProjectId = projectId };

            var response = await _api.DeleteProject(request, cancellationToken).ConfigureAwait(false);
        }
    }
}