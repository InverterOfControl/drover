using Drover.Contracts.Shared;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class TasksResponse
  {
    [JsonPropertyName("tasks")]
    public List<Task> Tasks { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
  }
}
