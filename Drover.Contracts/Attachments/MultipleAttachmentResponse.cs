using Drover.Contracts.Shared;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Attachments
{
  public class MultipleAttachmentResponse
  {
    [JsonPropertyName("attachments")]
    public IList<Attachment> Attachments { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
  }
}
