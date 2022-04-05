using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Webhooks
{
  public class ListWebhooksResponse
  {
    [JsonPropertyName("webhooks")]
    public List<Webhook> Webhooks { get; set; }
  }
}
