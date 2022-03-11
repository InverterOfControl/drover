using Refit;

namespace Drover.Contracts.Columns
{
  public class CreateColumnRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }
  }
}
