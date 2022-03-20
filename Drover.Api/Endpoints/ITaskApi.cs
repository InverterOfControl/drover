using Drover.Contracts.Tasks;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface ITaskApi
  {
    [Get("/api_v2/projects/{request.project_id}/tasks.json")]
    Task<TasksResponse> GetTasks(TasksRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/tasks/feedback.json")]
    Task<TasksResponse> GetFeedbackTasks(TasksRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/tasks/archive.json")]
    Task<TasksResponse> GetArchiveTasks(TasksRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/tasks/taskboard.json")]
    Task<TasksResponse> GetTaskboard(TasksRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/tasks/{request.task_id}.json")]
    Task<TaskResponse> GetTask(TasksRequest request, CancellationToken cancellationToken);

    [Get("/api_v2/projects/{request.project_id}/local_tasks/{request.task_id}.json")]
    Task<TaskResponse> GetLocalTask(TasksRequest request, CancellationToken cancellationToken);

    [Post("/api_v2/projects/{request.project_id}/tasks.json")]
    Task<TaskResponse> CreateTask(CreateTaskRequest request, CancellationToken cancellationToken);

    [Put("/api_v2/projects/{request.project_id}/tasks/{request.task_id}.json")]
    Task<TaskResponse> UpdateTask(UpdateTaskRequest request, CancellationToken cancellationToken);
  }
}
