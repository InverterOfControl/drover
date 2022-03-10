using Drover.Contracts.Organisation;
using Refit;

namespace Drover.Api.Endpoints
{
  internal interface IOrganisazionApi
  {
    [Get("/api_v2/organization.json")]
    Task<OrganisationResponse> GetOrganisation();
  }
}
