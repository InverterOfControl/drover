using System.Text.Json.Serialization;

namespace Drover.Contracts.Webhooks
{
  public class CreateWebhookResponse
  {
    [JsonPropertyName("webhook")]
    public Webhook Webhook { get; set; }
  }
}
