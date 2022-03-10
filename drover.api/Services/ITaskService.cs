using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface ITaskService
  {
    Task<IList<Drover.Contracts.Tasks.Task>> GetProjectTasks(long projectId);
  }
}
