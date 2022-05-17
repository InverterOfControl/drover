using Drover.Contracts.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface ITaskService
  {
    /// <summary>
    /// Retrieve all Tasks in a given project. The Tasks won't contain all the details.
    /// </summary>
    /// <param name="projectId"></param>
    /// <returns></returns>
    Task<IList<Contracts.Tasks.Task>> GetProjectTasks(long projectId, CancellationToken cancellationToken);

    /// <summary>
    /// Get a specific task from a project. This task contains all details.
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="taskId"></param>
    /// <returns></returns>
    Task<DetailedTask> GetTask(long projectId, long taskId, CancellationToken cancellationToken);

    /// <summary>
    /// Get a specific task from a project via the local task-id.
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="taskId"></param>
    /// <returns></returns>
    Task<DetailedTask> GetLocalTask(long projectId, long taskId, CancellationToken cancellationToken);

    Task<DetailedTask> CreateTask(CreateTaskRequest request, CancellationToken cancellationToken);

    Task<DetailedTask> UpdateTask(UpdateTaskRequest request, CancellationToken cancellationToken);

    /// <summary>
    /// Delete is not yet implemented by the Bugherd-Api.
    /// </summary>
    /// <param name="projectId"></param>
    /// <param name="taskId"></param>
    /// <returns></returns>
    [System.Obsolete("Delete is not yet implemented by the Bugherd-Api.")]
    System.Threading.Tasks.Task DeleteTask(long projectId, long taskId, CancellationToken cancellationToken);
  }
}
