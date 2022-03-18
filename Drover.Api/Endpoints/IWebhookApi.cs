using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
    internal interface IWebhookApi
    {
        Task ListWebhooks();

        Task CreateWebhook();

        Task DeleteWebhook();
    }
}
