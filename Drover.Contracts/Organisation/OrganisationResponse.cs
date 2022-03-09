using System.Text.Json.Serialization;

namespace Drover.Contracts.Organisation
{
  public class OrganisationResponse
  {
    [JsonPropertyName("organization")]
    public Organization Organization { get; set; }
  }

  public class Organization
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
  }

}
