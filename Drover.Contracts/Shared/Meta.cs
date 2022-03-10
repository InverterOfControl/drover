using System.Text.Json.Serialization;

namespace Drover.Contracts.Shared
{
  public class Meta
  {
    [JsonPropertyName("count")]
    public long Count { get; set; }
  }
}
