using Refit;

namespace Drover.Contracts.Projects
{
  public class DeleteProjectRequest
  {
    [AliasAs("project_id")]
    public int ProjectId { get; set; }
  }
}
