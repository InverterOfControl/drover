using Drover.Api.Factories;
using Drover.Contracts.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public class TaskService : BaseService, ITaskService
  {
    public TaskService(IBugherdConnection connection) : base(connection)
    {
    }

    public async Task<IList<Contracts.Tasks.Task>> GetProjectTasks(long projectId)
    {
      var service = CreateBugherdApi();

      var request = new TasksRequest { ProjectId = projectId };

      var response = await service.GetTasks(request);

      return response.Tasks;
    }
  }
}
