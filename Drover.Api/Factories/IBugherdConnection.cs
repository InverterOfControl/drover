using Drover.Api.Services;

namespace Drover.Api.Factories
{
  public interface IBugherdConnection
  {
    string ApiKey { get; init; }

    string BaseUri { get; init; }

    IOrganisationService CreateOrganisationService();

    ITaskService CreateTaskService();

    IUsersService CreateUsersService();

    IProjectService CreateProjectService();
  }
}