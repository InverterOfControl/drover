using Drover.Contracts.Organisation;

namespace Drover.Api.Services
{
  internal interface IOrganisationService
  {
    Task<Organization> GetOrganisation();
  }
}
