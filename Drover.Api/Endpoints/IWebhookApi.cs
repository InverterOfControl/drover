using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
    internal interface IWebhookApi
    {
        Task ListWebhooks(CancellationToken cancellationToken);

        Task CreateWebhook(CancellationToken cancellationToken);

        Task DeleteWebhook(CancellationToken cancellationToken);
    }
}
