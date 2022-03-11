using Refit;

namespace Drover.Contracts.Comments
{
  public class ListCommentRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("task_id")]
    public long TaskId { get; set; }
  }
}
