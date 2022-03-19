using System.Text.Json.Serialization;

namespace Drover.Contracts.Attachments
{
    public class DeleteAttachmentResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
