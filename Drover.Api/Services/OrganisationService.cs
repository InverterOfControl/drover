using Drover.Api.Endpoints;
using Drover.Api.Factories;
using Drover.Contracts.Organisation;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Services
{
    public class OrganisationService : BaseService, IOrganisationService
  {

    private readonly IOrganisazionApi _api;

    internal OrganisationService(IBugherdConnection connection) : base(connection)
    {
      _api = CreateApi<IOrganisazionApi>();
    }

    public async Task<Organization> GetOrganisation(CancellationToken cancellationToken)
    {
      var response = await _api.GetOrganisation(cancellationToken).ConfigureAwait(false);

      return response.Organization;
    }
  }
}
