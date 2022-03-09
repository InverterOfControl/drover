using Drover.Contracts.Organisation;
using Drover.Contracts.Users;
using Refit;

namespace Drover.Api
{
  public interface IBugherdApi
  {
    [Get("/api_v2/organization.json")]
    Task<OrganisationResponse> GetOrganisation();

    [Get("/api_v2/users.json")]
    Task<UsersResponse> GetUsers();

    [Get("/api_v2/users/members.json")]
    Task<UsersResponse> GetMembers();

    [Get("/api_v2/users/guests.json")]
    Task<UsersResponse> GetGuests();
  }
}
