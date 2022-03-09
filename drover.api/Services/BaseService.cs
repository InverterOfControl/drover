using Drover.Api.Factories;
using Drover.Api.Handler;
using Refit;

namespace Drover.Api.Services
{
  public abstract class BaseService
  {
    private readonly IBugherdConnection _connection;

    protected BaseService(IBugherdConnection connection)
    {
      _connection = connection;

    }

    internal IBugherdApi CreateBugherdApi()
    {
      var handler = new AuthHandler(_connection.ApiKey, "x");

      var service = RestService.For<IBugherdApi>(new HttpClient(handler)
      {
        BaseAddress = new Uri(_connection.BaseUri)
      });

      return service;
    }
  }
}