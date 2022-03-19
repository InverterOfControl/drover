using Drover.Contracts.Projects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetProjects(int? page = null );

        Task<List<Project>> GetActiveProjects(int? page = null);

        Task<Project> GetProject(int id);

        Task CreateProject(string name, string websiteUrl, bool isActive, bool isPublic, bool guestsSeeGuests);

        Task AddMember(int projectId, int memberId);

        /// <summary>
        /// Invite a Guest using his E-Mail or add an existing via his Id
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guestId"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        Task AddGuest(int projectId, int guestId, string email);

        Task DeleteProject(int projectId);
    }
}
