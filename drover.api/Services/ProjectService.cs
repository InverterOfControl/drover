using Drover.Api.Factories;
using Drover.Contracts.Projects;

namespace Drover.Api.Services
{
  public class ProjectService : BaseService, IProjectService
  {
    public ProjectService(IBugherdConnection connection) : base(connection)
    {
    }

    public async Task AddGuest(int projectId, int guestId, string email)
    {
      var service = CreateBugherdApi();

      var request = new AddGuestRequest { Email = email, ProjectId = projectId, UserId = guestId };

      var response = await service.AddGuest(request);
    }

    public async Task AddMember(int projectId, int memberId)
    {
      var service = CreateBugherdApi();

      var request = new AddMemberRequest { UserId = memberId, ProjectId = projectId };

      var response = await service.AddMember(request);
    }

    public async Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests)
    {
      var service = CreateBugherdApi();

      var project = new NewProject
      {
        GuestsSeeGuests = guestsSeeGuests,
        IsActive = isActive,
        IsPublic = isPublic,
        Name = name,
        WebsiteUrl = websiteUrl
      };

      var request = new CreateProjectRequest { Project = project };

      var response = await service.CreateProject(request);
    }

    public async Task<List<Project>> GetActiveProjects(int? page = null)
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

    public async Task<List<Project>> GetProjects(int? page = null)
    {
      var service = CreateBugherdApi();

      var request = new ProjectsRequest { Page = page };

      var response = await service.GetProjects(request);

      return response.Projects;
    }

    public async Task DeleteProject(int projectId)
    {
      var service = CreateBugherdApi();

      var request = new DeleteProjectRequest { ProjectId = projectId };

      var response = await service.DeleteProject(request);
    }
  }
}