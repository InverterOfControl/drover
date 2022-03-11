using System.Text.Json.Serialization;

namespace Drover.Contracts.Comments
{
  public class SingleCommentResponse
  {
    [JsonPropertyName("comment")]
    public Comment Comment { get; set; }
  }
}
