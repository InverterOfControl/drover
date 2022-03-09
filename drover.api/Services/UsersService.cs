using Drover.Api.Factories;
using Drover.Contracts.Users;

namespace Drover.Api.Services
{
  public class UsersService : BaseService, IUsersService
  {
    public UsersService(IBugherdConnection connection) : base(connection)
    {
    }

    public async Task<List<User>> GetGuests()
    {
      var service = CreateBugherdApi();

      var users = await service.GetGuests();

      return users.Users;
    }

    public async Task<List<User>> GetMembers()
    {
      var service = CreateBugherdApi();

      var members = await service.GetMembers();

      return members.Users;
    }

    public async Task<List<User>> GetUsers()
    {
      var service = CreateBugherdApi();

      var guests = await service.GetUsers();

      return guests.Users;
    }
  }
}
