using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Users;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public class UsersService : BaseService, IUsersService
  {
    private readonly IUserApi _api;

    internal UsersService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IUserApi>();
    }

    public async Task<List<User>> GetGuests(CancellationToken cancellationToken)
    {
      var users = await _api.GetGuests(cancellationToken).ConfigureAwait(false);

      return users.Users;
    }

    public async Task<List<User>> GetMembers(CancellationToken cancellationToken)
    {
      var members = await _api.GetMembers(cancellationToken).ConfigureAwait(false);

      return members.Users;
    }

    public async Task<List<User>> GetUsers(CancellationToken cancellationToken)
    {
      var guests = await _api.GetUsers(cancellationToken).ConfigureAwait(false);

      return guests.Users;
    }
  }
}
