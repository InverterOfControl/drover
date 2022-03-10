using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Api.Handler;
using Drover.Contracts.Organisation;
using Refit;

namespace Drover.Api.Services
{
  public class OrganisationService : BaseService, IOrganisationService
  {

    private readonly IOrganisazionApi _api;

    internal OrganisationService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IOrganisazionApi>();
    }

    public async Task<Organization> GetOrganisation()
    {
      var response = await _api.GetOrganisation();

      return response.Organization;
    }
  }
}
