using System.Runtime.Serialization;

namespace Drover.Contracts.Webhooks
{
  public enum WebhookEvent
  {
    [EnumMember(Value = "task_create")]
    Create,
    [EnumMember(Value = "task_update")]
    Update,
    [EnumMember(Value = "task_delete")]
    Delete
  }
}
