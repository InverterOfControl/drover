using Drover.Tests.Infrastructure;
using System.Threading.Tasks;
using Xunit;

namespace Drover.Tests.Integration.Users
{
    public class UserServiceTests
    {
        [Fact]
        public async Task GetProjectUsersAsync()
        {
            var userService = Connection.BugherdConnection.CreateUsersService();

            var users = await userService.GetUsers(new System.Threading.CancellationToken());

            Assert.NotEmpty(users);
        }

        [Fact]
        public async Task GetProjectGuestsAsync()
        {
            var userService = Connection.BugherdConnection.CreateUsersService();

            var guests = await userService.GetGuests(new System.Threading.CancellationToken());

            Assert.Empty(guests);
        }

        [Fact]
        public async Task GetProjectMembers()
        {
            var userService = Connection.BugherdConnection.CreateUsersService();

            var members = await userService.GetMembers(new System.Threading.CancellationToken());

            Assert.NotEmpty(members);
        }
    }
}
