using Refit;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class CreateTaskRequest
  {
    [JsonPropertyName("task")]
    public NewTask NewTask { get; set; }

    [AliasAs("project_id")]
    [JsonIgnore]
    public long ProjectId { get; set; }
  }

  public class NewTask
  {
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("priority")]
    public TaskPriority Priority { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("requester_id")]
    public long? RequesterId { get; set; }

    [JsonPropertyName("tag_names")]
    public List<string> TagNames { get; set; }

    [JsonPropertyName("assigned_to_id")]
    public long? AssignedToId { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    [JsonPropertyName("requester_email")]
    public string RequesterEmail { get; set; }

    [JsonPropertyName("assigned_to_email")]
    public string AssignedToEmail { get; set; }
  }
}
