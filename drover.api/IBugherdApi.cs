using Refit;
using Drover.Contracts.Organisation;
using Drover.Contracts.Users;
using Drover.Contracts.Projects;
using Drover.Contracts.Tasks;

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

    [Post("/api_v2/projects/{request.project_id}/add_member.json")]
    Task<AddMemberResponse> AddMember(AddMemberRequest request);

    [Post("/api_v2/projects/{request.project_id}/add_guest.json")]
    Task<AddGuestResponse> AddGuest(AddGuestRequest request);

    [Put("/api_v2/projects/{request.project_id}.json")]
    Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest request);

    [Delete("/api_v2/projects/{request.project_id}.json")]
    Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest request);

    [Get("/api_v2/projects/{request.project_id}/tasks.json")]
    Task<TasksResponse> GetTasks(TasksRequest request);
  }
}
