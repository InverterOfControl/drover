using Drover.Contracts.Projects;
using Refit;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface IProjectApi
  {
    [Get("/api_v2/projects.json")]
    Task<ProjectsResponse> GetProjects(ProjectsRequest request);

    [Get("/api_v2/projects/active.json")]
    Task<ProjectsResponse> GetActiveProjects(ProjectsRequest request);

    [Get("/api_v2/projects/{request.project_id}.json")]
    Task<SingleProjectResponse> GetProject(SingleProjectRequest request);

    [Post("/api_v2/projects.json")]
    Task<CreateProjectResponse> CreateProject([Body] CreateProjectRequest request);

    [Post("/api_v2/projects/{request.project_id}/add_member.json")]
    Task<AddMemberResponse> AddMember(AddMemberRequest request);

    [Post("/api_v2/projects/{request.project_id}/add_guest.json")]
    Task<AddGuestResponse> AddGuest(AddGuestRequest request);

    [Put("/api_v2/projects/{request.project_id}.json")]
    Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest request);

    [Delete("/api_v2/projects/{request.project_id}.json")]
    Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest request);
  }
}
