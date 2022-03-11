using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Columns
{
  public class MultipleColumnResponse
  {
    [JsonPropertyName("columns")]
    public List<Column> Columns { get; set; }
  }
}
