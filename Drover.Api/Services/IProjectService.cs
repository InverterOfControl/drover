using Drover.Contracts.Projects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects(CancellationToken cancellationToken);

        Task<List<Project>> GetProjects(int? page, CancellationToken cancellationToken);

        Task<List<Project>> GetActiveProjects(int? page, CancellationToken cancellationToken);

        Task<Project> GetProject(int id, CancellationToken cancellationToken);

        Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests, CancellationToken cancellationToken);

        Task AddMember(int projectId, int memberId, CancellationToken cancellationToken);

        /// <summary>
        /// Invite a Guest using his E-Mail or add an existing via its Id
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guestId"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        Task AddGuest(int projectId, int guestId, string email, CancellationToken cancellationToken);

        Task DeleteProject(int projectId, CancellationToken cancellationToken);
    }
}
