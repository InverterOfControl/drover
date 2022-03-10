using Drover.Contracts.Users;

namespace Drover.Api.Services
{
  public interface IUsersService
  {
    Task<List<User>> GetUsers();

    Task<List<User>> GetMembers();

    Task<List<User>> GetGuests();
  }
}
