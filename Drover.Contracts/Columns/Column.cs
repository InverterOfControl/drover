using Refit;
using System;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Columns
{
  public class Column
  {
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    [AliasAs("name")]
    public string Name { get; set; }

    [JsonPropertyName("project_id")]
    public long? ProjectId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
  }
}
