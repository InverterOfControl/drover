namespace Drover.Api.Factories
{
  public static class ConnectionFactory
  {
    public static IBugherdConnection CreateConnection(string apiKey, string baseUri)
    {
      if (string.IsNullOrWhiteSpace(apiKey))
      {
        throw new ArgumentNullException(nameof(apiKey));
      }

      if (string.IsNullOrWhiteSpace(baseUri))
      {
        throw new ArgumentNullException(nameof(baseUri));
      }

      return new BugherdConnection(apiKey, baseUri);
    }
  }
}
