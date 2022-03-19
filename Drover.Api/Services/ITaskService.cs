using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface ITaskService
  {
    Task<IList<Contracts.Tasks.Task>> GetProjectTasks(long projectId);

    Task<Contracts.Tasks.DetailedTask> GetTask(long projectId, long taskId);

    Task<Contracts.Tasks.DetailedTask> GetLocalTask(long projectId, long taskId);
  }
}
