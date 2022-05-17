using Refit;
using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Webhooks
{
  public class CreateWebhookRequest
  {
    [JsonPropertyName("project_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? ProjectId { get; set; }

    [JsonPropertyName("target_url")]
    public string TargetUrl { get; set; }

    //[AliasAs("event")]
    [JsonPropertyName("event")]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public WebhookEvent Event { get; set; }
  }
}
