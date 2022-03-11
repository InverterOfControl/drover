using Refit;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Columns
{
  public class UpdateColumnRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("column_id")]
    public long ColumnId { get; set; }
  }
}
