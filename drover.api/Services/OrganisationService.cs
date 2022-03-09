using Drover.Api.Factories;
using Drover.Api.Handler;
using Drover.Contracts.Organisation;
using Refit;

namespace Drover.Api.Services
{
  public class OrganisationService : BaseService, IOrganisationService
  {

    public OrganisationService(IBugherdConnection connection) : base(connection)
    {

    }

    public async Task<Organization> GetOrganisation()
    {
      var service = CreateBugherdApi();

      var response = await service.GetOrganisation();

      return response.Organization;
    }
  }
}
