using Refit;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class UpdateTaskRequest
  {
    [AliasAs("project_id")]
    [JsonIgnore]
    public long ProjectId { get; set; }

    [AliasAs("task_id")]
    [JsonIgnore]
    public long TaskId { get; set; }

    [JsonPropertyName("task")]
    public NewTask UpdatedTask { get; set; }
  }
}
