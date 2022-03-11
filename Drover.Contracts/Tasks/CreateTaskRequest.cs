using Refit;
using System.Collections.Generic;

namespace Drover.Contracts.Tasks
{
  public class CreateTaskRequest
  {
    [AliasAs("task")]
    public NewTask NewTask { get; set; }

    [AliasAs("project_id")]
    public long ProjectId { get; set; }
  }

  public class NewTask
  {
    [AliasAs("description")]
    public string Description { get; set; }

    [AliasAs("priority")]
    public string Priority { get; set; }

    [AliasAs("status")]
    public string Status { get; set; }

    [AliasAs("requester_id")]
    public long? RequesterId { get; set; }

    [AliasAs("tag_names")]
    public List<string> TagNames { get; set; }

    [AliasAs("assigned_to_id")]
    public long? AssignedToId { get; set; }

    [AliasAs("external_id")]
    public string ExternalId { get; set; }

    [AliasAs("requester_email")]
    public string RequesterEmail { get; set; }

    [AliasAs("assigned_to_email")]
    public string AssignedToEmail { get; set; }
  }
}
