using Drover.Contracts.Organisation;
using Refit;
using System.Threading.Tasks;

namespace Drover.Api.Endpoints
{
  internal interface IOrganisazionApi
  {
    [Get("/api_v2/organization.json")]
    Task<OrganisationResponse> GetOrganisation();
  }
}
