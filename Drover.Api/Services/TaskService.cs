using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public class TaskService : BaseService, ITaskService
  {
    private readonly ITaskApi _api;

    internal TaskService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<ITaskApi>();
    }

    public async Task<DetailedTask> GetLocalTask(long projectId, long taskId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId, TaskId = taskId };

      var response = await _api.GetLocalTask(request, cancellationToken).ConfigureAwait(false);

      return response.Task;
    }

    public async Task<IList<Contracts.Tasks.Task>> GetProjectTasks(long projectId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId };

      var response = await _api.GetTasks(request, cancellationToken).ConfigureAwait(false);

      return response.Tasks;
    }

    public async Task<DetailedTask> GetTask(long projectId, long taskId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId, TaskId = taskId };

      var response = await _api.GetTask(request, cancellationToken).ConfigureAwait(false);

      return response.Task;
    }
  }
}
