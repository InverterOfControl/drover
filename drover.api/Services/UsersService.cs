using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Users;

namespace Drover.Api.Services
{
  public class UsersService : BaseService, IUsersService
  {
    private readonly IUserApi _api;

    internal UsersService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IUserApi>();
    }

    public async Task<List<User>> GetGuests()
    {
      var users = await _api.GetGuests();

      return users.Users;
    }

    public async Task<List<User>> GetMembers()
    {
      var members = await _api.GetMembers();

      return members.Users;
    }

    public async Task<List<User>> GetUsers()
    {
      var guests = await _api.GetUsers();

      return guests.Users;
    }
  }
}
