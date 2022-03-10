using Refit;

namespace Drover.Contracts.Tasks
{
  public class TasksRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }
  }
}
