using Drover.Api.Converter;
using Drover.Api.Factories;
using Drover.Api.Handler;
using Refit;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Drover.Api.Services
{
  public abstract class BaseService
  {
    private readonly IBugherdConnection _connection;

    protected BaseService(IBugherdConnection connection)
    {
      _connection = connection;

    }

    internal T CreateApi<T>()
    {

#if DEBUG
      var authHandler = new AuthHandler(_connection.ApiKey, "x");
      var handler = new HttpLoggingHandler(authHandler);

#else
      var handler = new AuthHandler(_connection.ApiKey, "x");
#endif

      var jsonSerializerOptions = new JsonSerializerOptions();
      jsonSerializerOptions.Converters.Add(new EnumToStringConverter(JsonNamingPolicy.CamelCase));

      var service = RestService.For<T>(new HttpClient(handler)
      {
        BaseAddress = new Uri(_connection.BaseUri)
      },
        new RefitSettings(new SystemTextJsonContentSerializer(jsonSerializerOptions))
       );

      return service;
    }
  }
}