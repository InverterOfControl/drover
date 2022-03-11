using Refit;

namespace Drover.Contracts.Columns
{
  public class SingleColumnRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("column_id")]
    public long ColumnId { get; set; }

  }
}
