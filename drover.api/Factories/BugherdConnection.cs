using Refit;

namespace Drover.Api.Factories
{
  internal class BugherdConnection : IBugherdConnection
  {
    public string ApiKey { get; init; }
    public string BaseUri { get; init; }

    public BugherdConnection(string apiKey, string baseUri)
    {
      ApiKey = apiKey;

      BaseUri = baseUri;
    }
  }
}