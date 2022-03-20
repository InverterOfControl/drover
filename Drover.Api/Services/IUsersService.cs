using Drover.Contracts.Users;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public interface IUsersService
    {
        /// <summary>
        /// Returns a list of all users in your project.
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetUsers(CancellationToken cancellationToken);

        /// <summary>
        /// Returns a list of all registered users in your project.
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetMembers(CancellationToken cancellationToken);

        /// <summary>
        /// Returns a list of all guests in the project.
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetGuests(CancellationToken cancellationToken);
    }
}
