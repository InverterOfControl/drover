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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    [JsonPropertyName("priority")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public TaskPriority Priority { get; set; } = TaskPriority.NotSet;

    [JsonPropertyName("status")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Status { get; set; }

    [JsonPropertyName("requester_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? RequesterId { get; set; }

    [JsonPropertyName("tag_names")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> TagNames { get; set; }

    [JsonPropertyName("assigned_to_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? AssignedToId { get; set; }

    [JsonPropertyName("external_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ExternalId { get; set; }

    [JsonPropertyName("requester_email")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string RequesterEmail { get; set; }

    [JsonPropertyName("assigned_to_email")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string AssignedToEmail { get; set; }
  }
}
