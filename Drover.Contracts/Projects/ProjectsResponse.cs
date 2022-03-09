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

   public class Meta
  {
    [JsonPropertyName("count")]
    public long Count { get; set; }
  }

   public class Project
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("has_custom_columns")]
        public bool HasCustomColumns { get; set; }

        [JsonPropertyName("guests_see_guests")]
        public bool GuestsSeeGuests { get; set; }
    }
}
