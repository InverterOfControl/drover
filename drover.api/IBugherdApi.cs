using Drover.Contracts.Organisation;
using Drover.Contracts.Users;
using Drover.Contracts.Projects;
using Refit;

namespace Drover.Api
{
  public interface IBugherdApi
  {
    [Get("/api_v2/organization.json")]
    Task<OrganisationResponse> GetOrganisation();

    [Get("/api_v2/users.json")]
    Task<UsersResponse> GetUsers();

    [Get("/api_v2/users/members.json")]
    Task<UsersResponse> GetMembers();

    [Get("/api_v2/users/guests.json")]
    Task<UsersResponse> GetGuests();

    [Get("/api_v2/projects.json")]
    Task<ProjectsResponse> GetProjects(ProjectsRequest request);

    [Get("/api_v2/projects/active.json")]
    Task<ProjectsResponse> GetActiveProjects(ProjectsRequest request);

    [Get("/api_v2/projects/#{request.project_id}.json")]
    Task<SingleProjectResponse> GetProject(SingleProjectRequest request);

    [Post("/api_v2/projects.json")]
    Task<CreateProjectResponse> CreateProject(CreateProjectRequest request);
  }
}
