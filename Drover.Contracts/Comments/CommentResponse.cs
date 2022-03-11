using Drover.Contracts.Shared;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Comments
{
  public class CommentResponse
  {
    [JsonPropertyName("comments")]
    public List<Comment> Comments { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
  }
}
