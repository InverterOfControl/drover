using Refit;

namespace Drover.Contracts.Comments
{
  public class CreateCommentRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("task_id")]
    public long TaskId { get; set; }
  }

  public class NewComment
  {
    [AliasAs("text")]
    public string Text { get; set; }


    [AliasAs("user_id")]
    public long UserId { get; set; }
  }
}
