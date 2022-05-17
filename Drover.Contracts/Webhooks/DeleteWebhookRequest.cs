using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drover.Contracts.Webhooks
{
  public class DeleteWebhookRequest
  {
    [AliasAs("id")]
    public long HookId { get; set; }
  }
}
