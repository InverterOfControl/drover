using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Tasks;
using System;
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

    public async Task<DetailedTask> CreateTask(CreateTaskRequest request, CancellationToken cancellationToken)
    {
      if(request == null)
      {
        return null;
      }

      if(request.NewTask == null)
      {
        return null;
      }

      var response = await _api.CreateTask(request, cancellationToken);

      return response.Task;
    }

    public async System.Threading.Tasks.Task DeleteTask(long projectId, long taskId, CancellationToken cancellationToken)
    {
      await System.Threading.Tasks.Task.FromResult(0);

      throw new NotImplementedException("Delete is not yet implemented by the Bugherd-Api");

      //var request = new DeleteTaskRequest
      //{
      //  ProjectId = projectId,
      //  TaskId = taskId
      //};

      //await _api.DeleteTask(request);
    }

    public async Task<DetailedTask> GetLocalTask(long projectId, long taskId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId, TaskId = taskId };

      var response = await _api.GetLocalTask(request, cancellationToken);

      return response.Task;
    }

    public async Task<IList<Contracts.Tasks.Task>> GetProjectTasks(long projectId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId };

      var response = await _api.GetTasks(request, cancellationToken);

      return response.Tasks;
    }

    public async Task<DetailedTask> GetTask(long projectId, long taskId, CancellationToken cancellationToken)
    {
      var request = new TasksRequest { ProjectId = projectId, TaskId = taskId };

      var response = await _api.GetTask(request, cancellationToken);

      return response.Task;
    }

    public async Task<DetailedTask> UpdateTask(UpdateTaskRequest request, CancellationToken cancellationToken)
    {
      var response = await _api.UpdateTask(request, cancellationToken);

      return response.Task;
    }
  }
}
