using System.Text.Json.Serialization;

namespace Drover.Contracts.Projects
{
    public class SingleProjectResponse
    {
        [JsonPropertyName("project")]
        public Project Project { get; set; }
    }
}
