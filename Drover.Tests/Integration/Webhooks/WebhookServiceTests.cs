using Drover.Tests.Infrastructure;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Drover.Tests.Integration.Webhooks
{
  public class WebhookServiceTests
  {
    [Fact]
    public async Task CreateListAndDelete()
    {
      var webhookService = Connection.BugherdConnection.CreateWebhookService();

      // Create a hook
      var newWebhook = await webhookService.CreateWebhook(
        new Uri("http://www.google.com"),
        Contracts.Webhooks.WebhookEvent.Update);

      Assert.NotNull(newWebhook);

      var retrievedWebhooks = await webhookService.ListWebhooks();

      // check if new hook is returned with possible other hooks
      Assert.Contains(retrievedWebhooks, hook => hook.Id == newWebhook.Id);

      // delete that hook
      var deletionResult = await webhookService.DeleteWebhook(newWebhook.Id);

      Assert.True(deletionResult);
    }


  }
}
