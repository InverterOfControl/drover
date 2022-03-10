using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class Task
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("closed_at")]
    public object ClosedAt { get; set; }

    [JsonPropertyName("local_task_id")]
    public long LocalTaskId { get; set; }

    [JsonPropertyName("priority_id")]
    public long PriorityId { get; set; }

    [JsonPropertyName("assigned_to_id")]
    public long? AssignedToId { get; set; }

    [JsonPropertyName("status_id")]
    public long? StatusId { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("tag_names")]
    public string[] TagNames { get; set; }

    [JsonPropertyName("external_id")]
    public object ExternalId { get; set; }

    [JsonPropertyName("requester_id")]
    public long? RequesterId { get; set; }

    [JsonPropertyName("requester_email")]
    public string RequesterEmail { get; set; }

    [JsonPropertyName("due_at")]
    public object DueAt { get; set; }

    [JsonPropertyName("assignee_ids")]
    public long[] AssigneeIds { get; set; }

    [JsonPropertyName("column_id")]
    public long? ColumnId { get; set; }
  }
}
