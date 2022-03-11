using System.Text.Json.Serialization;

namespace Drover.Contracts.Columns
{
  public class SingleColumnResponse
  {
    [JsonPropertyName("column")]
    public Column Column { get; set; }
  }
}
