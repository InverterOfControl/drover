using Drover.Contracts.Organisation;

namespace Drover.Api.Services
{
  public interface IOrganisationService
  {
    Task<Organization> GetOrganisation();
  }
}
