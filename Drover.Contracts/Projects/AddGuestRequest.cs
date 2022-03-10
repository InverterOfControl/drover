using Refit;

namespace Drover.Contracts.Projects
{
  public class AddGuestRequest
  {
    [AliasAs("project_id")]
    public int ProjectId { get; set; }

    [AliasAs("user_id")]
    public int? UserId { get; set; }

    [AliasAs("email")]
    public string Email { get; set; }
  }
}
