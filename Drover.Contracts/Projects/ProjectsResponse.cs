using Drover.Contracts.Shared;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Projects
{
  public class ProjectsResponse
  {
    [JsonPropertyName("projects")]
    public List<Project> Projects { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
  }

  public class Project
  {
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("has_custom_columns")]
    public bool HasCustomColumns { get; set; }
  }
}
