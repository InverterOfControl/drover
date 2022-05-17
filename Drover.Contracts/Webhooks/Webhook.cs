using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Webhooks
{
  public class Webhook
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("target_url")]
    public string TargetUrl { get; set; }

    [JsonPropertyName("event")]
    public string Event { get; set; }

    [JsonPropertyName("project_id")]
    public long? ProjectId { get; set; }

    [JsonPropertyName("success_count")]
    public long? SuccessCount { get; set; }

    [JsonPropertyName("error_count")]
    public long? ErrorCount { get; set; }

    [JsonPropertyName("last_error_code")]
    public string LastErrorCode { get; set; }

    [JsonPropertyName("last_error_at")]
    public DateTimeOffset? LastErrorAt { get; set; }

    [JsonPropertyName("first_error_at")]
    public DateTimeOffset? FirstErrorAt { get; set; }

    [JsonPropertyName("first_success_at")]
    public DateTimeOffset? FirstSuccessAt { get; set; }

    [JsonPropertyName("last_success_at")]
    public DateTimeOffset? LastSuccessAt { get; set; }
  }
}
