using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Comments
{
  public class Comment
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }
  }
}
