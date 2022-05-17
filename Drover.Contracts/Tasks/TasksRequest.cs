using Refit;
using System;

namespace Drover.Contracts.Tasks
{
  public class TasksRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("task_id")]
    public long TaskId { get; set; }

    [AliasAs("updated_since")]
    public DateTimeOffset UpdatedSince { get; set; }

    [AliasAs("created_since")]
    public DateTimeOffset CreatedSince { get; set; }

    [AliasAs("status")]
    public string Status { get; set; }

    [AliasAs("priority")]
    public string Priority { get; set; }
    
    [AliasAs("tag")]
    public string Tag { get; set; }

    [AliasAs("assigned_to_id")]
    public long? AssingedTo { get; set; }

    [AliasAs("external_id")]
    public string ExternalId { get; set; }

    [AliasAs("page")]
    public int? Page { get; set; }
  }
}
