using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Attachments
{
    public class AttachmentResponse
    {
        [JsonPropertyName("attachment")]
        public Attachment Attachment { get; set; }
    }
}
