using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Webhooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public class WebhookService : BaseService, IWebhookService
  {
    private readonly IWebhookApi _api;

    public WebhookService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IWebhookApi>();
    }

    public async Task<Webhook> CreateWebhook(Uri targetUrl, WebhookEvent webhookEvent, long? projectId = null)
    {
      var request = new CreateWebhookRequest
      {
        TargetUrl = targetUrl.ToString(),
        Event = webhookEvent,
        ProjectId = projectId
      };

      var response = await _api.CreateWebhook(request).ConfigureAwait(false);

      return response.Webhook;
    }

    public async Task<bool> DeleteWebhook(long webhookId)
    {
      var request = new DeleteWebhookRequest { HookId = webhookId };

      var response = await _api.DeleteWebhook(request).ConfigureAwait(false);

      return response.Success;
    }

    public async Task<IList<Webhook>> ListWebhooks()
    {
      var response = await _api.ListWebhooks();

      return response.Webhooks;
    }
  }
}
