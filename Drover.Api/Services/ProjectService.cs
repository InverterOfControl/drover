using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Projects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public class ProjectService : BaseService, IProjectService
  {
    private readonly IProjectApi _api;

    internal ProjectService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IProjectApi>();
    }

    public async Task AddGuest(int projectId, int guestId, string email)
    {
      var request = new AddGuestRequest { Email = email, ProjectId = projectId, UserId = guestId };

      var response = await _api.AddGuest(request);
    }

    public async Task AddMember(int projectId, int memberId)
    {
      var request = new AddMemberRequest { UserId = memberId, ProjectId = projectId };

      var response = await _api.AddMember(request);
    }

    public async Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests)
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

      var response = await _api.CreateProject(request);
    }

    public async Task<List<Project>> GetActiveProjects(int? page = null)
    {
      var request = new ProjectsRequest { Page = page };

      var response = await _api.GetActiveProjects(request);

      return response.Projects;
    }

    public async Task<Project> GetProject(int id)
    {
      var request = new SingleProjectRequest { Id = id };

      var response = await _api.GetProject(request);

      return response.Project;
    }

    public async Task<List<Project>> GetProjects(int? page = null)
    {
      var request = new ProjectsRequest { Page = page };

      var response = await _api.GetProjects(request);

      return response.Projects;
    }

    public async Task DeleteProject(int projectId)
    {
      var request = new DeleteProjectRequest { ProjectId = projectId };

      var response = await _api.DeleteProject(request);
    }
  }
}