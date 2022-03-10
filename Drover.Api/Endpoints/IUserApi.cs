using Drover.Contracts.Users;
using Refit;

namespace Drover.Api.Endpoints
{
  internal interface IUserApi
  {
    [Get("/api_v2/users.json")]
    Task<UsersResponse> GetUsers();

    [Get("/api_v2/users/members.json")]
    Task<UsersResponse> GetMembers();

    [Get("/api_v2/users/guests.json")]
    Task<UsersResponse> GetGuests();
  }
}
