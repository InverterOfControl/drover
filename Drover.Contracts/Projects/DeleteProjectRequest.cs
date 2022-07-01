using Refit;

namespace Drover.Contracts.Projects
{
  public class DeleteProjectRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }
  }
}
