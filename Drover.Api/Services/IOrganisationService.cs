using Drover.Contracts.Organisation;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
  public interface IOrganisationService
  {
    Task<Organization> GetOrganisation();
  }
}
