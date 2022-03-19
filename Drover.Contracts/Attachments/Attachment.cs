using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Attachments
{
    public class Attachment
    {
        [JsonPropertyName("id")]
        public long? id { get; set; }

        [JsonPropertyName("task_id")]
        public long? TaskId { get; set; }

        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}
