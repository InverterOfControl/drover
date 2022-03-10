using Refit;

namespace Drover.Contracts.Projects
{
  public class UpdateProjectRequest
  {
    [AliasAs("project")]
    public Project Project { get; set; }

    [AliasAs("project_id")]
    public int ProjectId { get; set; }
  }
}
