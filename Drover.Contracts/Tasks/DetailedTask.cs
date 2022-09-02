using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Tasks
{
  public class DetailedTask
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("project_id")]
    public long ProjectId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("local_task_id")]
    public long LocalTaskId { get; set; }

    [JsonPropertyName("priority_id")]
    public long PriorityId { get; set; }

    [JsonPropertyName("status_id")]
    public long? StatusId { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("tag_names")]
    public List<string> TagNames { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    [JsonPropertyName("requester_email")]
    public string RequesterEmail { get; set; }

    [JsonPropertyName("attachments")]
    public List<object> Attachments { get; set; }

    [JsonPropertyName("screenshot_url")]
    public Uri ScreenshotUrl { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("priority")]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public TaskPriority Priority { get; set; } = TaskPriority.NotSet;

    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    [JsonPropertyName("secret_link")]
    public Uri SecretLink { get; set; }

    [JsonPropertyName("admin_link")]
    public Uri AdminLink { get; set; }

    [JsonPropertyName("deleted_at")]
    public DateTimeOffset? DeletedAt { get; set; }

    [JsonPropertyName("site")]
    public Uri Site { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("screenshot_data")]
    public ScreenshotData ScreenshotData { get; set; } = new ScreenshotData();

    [JsonPropertyName("requester_os")]
    public string RequesterOs { get; set; }

    [JsonPropertyName("requester_browser")]
    public string RequesterBrowser { get; set; }

    [JsonPropertyName("requester_browser_size")]
    public string RequesterBrowserSize { get; set; }

    [JsonPropertyName("requester_resolution")]
    public string RequesterResolution { get; set; }

    [JsonPropertyName("selector_info")]
    [JsonIgnore]
    public SelectorInfo SelectorInfo { get; set; } = new SelectorInfo();

    [JsonPropertyName("due_at")]
    public DateTimeOffset? DueAt { get; set; }

    [JsonPropertyName("column_id")]
    public long? ColumnId { get; set; }

    [JsonPropertyName("assignees")]
    public List<TaskUser> Assignees { get; set; }

    [JsonPropertyName("assigned_to")]
    public TaskUser AssignedTo { get; set; }

    [JsonPropertyName("requester")]
    public TaskUser Requester { get; set; }

    [JsonPropertyName("updater")]
    public TaskUser Updater { get; set; }
  }

  public partial class Metadata
  {
  }

  public partial class TaskUser
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("avatar_url")]
    public Uri AvatarUrl { get; set; }
  }

  public partial class ScreenshotData
  {
    [JsonPropertyName("screenshot_width")]
    public long? ScreenshotWidth { get; set; }

    [JsonPropertyName("screenshot_height")]
    public long? ScreenshotHeight { get; set; }

    [JsonPropertyName("screenshot_pin_x")]
    public float? ScreenshotPinX { get; set; }

    [JsonPropertyName("screenshot_pin_y")]
    public float? ScreenshotPinY { get; set; }
  }

  public partial class SelectorInfo
  {
    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("html")]
    public string Html { get; set; }

    [JsonPropertyName("version")]
    public long? Version { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; } = new Data();
  }

  public partial class Data
  {
    [JsonPropertyName("bugOffsetX")]
    public double? BugOffsetX { get; set; }

    [JsonPropertyName("bugOffsetY")]
    public double? BugOffsetY { get; set; }
  }
}
