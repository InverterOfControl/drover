using Refit;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Projects
{
  public class AddMemberRequest
  {
    [AliasAs("project_id")]
    public long ProjectId { get; set; }

    [AliasAs("user_id")]
    public int UserId { get; set; }
  }
}
