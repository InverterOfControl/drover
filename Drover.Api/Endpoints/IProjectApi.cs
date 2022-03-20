using Drover.Contracts.Projects;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface IProjectApi
  {
    [Get("/api_v2/projects.json")]
    Task<ProjectsResponse> GetProjects(ProjectsRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/active.json")]
    Task<ProjectsResponse> GetActiveProjects(ProjectsRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}.json")]
    Task<SingleProjectResponse> GetProject(SingleProjectRequest request, CancellationToken cancellationToken);

    [Post("/api_v2/projects.json")]
    Task<CreateProjectResponse> CreateProject([Body] CreateProjectRequest request, CancellationToken cancellationToken);

    [Post("/api_v2/projects/{request.project_id}/add_member.json")]
    Task<AddMemberResponse> AddMember(AddMemberRequest request, CancellationToken cancellationToken);

    [Post("/api_v2/projects/{request.project_id}/add_guest.json")]
    Task<AddGuestResponse> AddGuest(AddGuestRequest request, CancellationToken cancellationToken);

    [Put("/api_v2/projects/{request.project_id}.json")]
    Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest request, CancellationToken cancellationToken);

    [Delete("/api_v2/projects/{request.project_id}.json")]
    Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest request, CancellationToken cancellationToken);
  }
}
