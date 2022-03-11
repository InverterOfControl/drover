using Refit;

namespace Drover.Contracts.Columns
{
  public class ListColumnRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }
  }
}
