using Drover.Contracts.Webhooks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface IWebhookService
  {
    /// <summary>
    /// List all webhooks
    /// </summary>
    /// <returns>A List of webhooks.</returns>
    Task<IList<Webhook>> ListWebhooks();

    /// <summary>
    /// Creates a webhook that Bugherd will post to if the matching <see cref="WebhookEvent"/> is triggered.
    /// </summary>
    /// <param name="targetUrl">The URL to post the Event-Data to.</param>
    /// <param name="webhookEvent">The type of the webhook will be triggered for. Can be Create, Update or Delete.</param>
    /// <param name="projectId">Optional. It only needs to be specified if you'd only like events on a specific project. Omitting project-id results in notifications of activity on all your projects.</param>
    /// <returns>The created webhook.</returns>
    Task<Webhook> CreateWebhook(Uri targetUrl, WebhookEvent webhookEvent, long? projectId = null);

    /// <summary>
    /// Deletes the specified webhook.
    /// </summary>
    /// <param name="webhookId"></param>
    /// <returns>true if deletion was successful. Else false.</returns>
    Task<bool> DeleteWebhook(long webhookId);
  }
}
