using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Drover.Contracts.Users
{
  public class UsersResponse
  {
    [JsonPropertyName("users")]
    public List<User> Users { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
  }

  public class Meta
  {
    [JsonPropertyName("count")]
    public long Count { get; set; }
  }
  public class User
  {
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("avatar_url")]
    public Uri AvatarUrl { get; set; }
  }

}
