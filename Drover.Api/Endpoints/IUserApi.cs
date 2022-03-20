using Drover.Contracts.Users;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface IUserApi
  {
    [Get("/api_v2/users.json")]
    Task<UsersResponse> GetUsers(CancellationToken cancellationToken);

    [Get("/api_v2/users/members.json")]
    Task<UsersResponse> GetMembers(CancellationToken cancellationToken);

    [Get("/api_v2/users/guests.json")]
    Task<UsersResponse> GetGuests(CancellationToken cancellationToken);
  }
}
