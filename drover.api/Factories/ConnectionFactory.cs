namespace Drover.Api.Factories
{
  public static class ConnectionFactory
  {
    public static IBugherdConnection CreateConnection(string apiKey, string baseUri)
    {
      return new BugherdConnection(apiKey, baseUri);
    }
  }
}
