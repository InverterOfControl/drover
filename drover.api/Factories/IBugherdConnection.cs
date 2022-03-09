using Refit;

namespace Drover.Api.Factories
{
  public interface IBugherdConnection
  {
    string ApiKey { get; init; }

    string BaseUri { get; init; }
  }
}