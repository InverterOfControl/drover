using Drover.Contracts.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public interface IUsersService
    {
        Task<List<User>> GetUsers();

        Task<List<User>> GetMembers();

        Task<List<User>> GetGuests();
    }
}
