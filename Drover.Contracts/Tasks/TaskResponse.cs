using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class TaskResponse
  {
    [JsonPropertyName("task")]
    public DetailedTask Task { get; set; }

  }
}
