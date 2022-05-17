using System.Text.Json.Serialization;

namespace Drover.Contracts.Webhooks
{
  public class DeleteWebhookResponse
  {
    [JsonPropertyName("success")]
    public bool Success { get; set; }
  }
}
