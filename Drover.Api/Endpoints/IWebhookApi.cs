using Drover.Contracts.Webhooks;
using Refit;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
    public interface IWebhookApi
    {
        [Get("/api_v2/webhooks.json")]
        Task<ListWebhooksResponse> ListWebhooks();

        [Post("/api_v2/webhooks.json")]
        Task<CreateWebhookResponse> CreateWebhook(CreateWebhookRequest request);

        [Delete("/api_v2/webhooks/{request.id}.json")]
        Task<DeleteWebhookResponse> DeleteWebhook(DeleteWebhookRequest request);
    }
}
