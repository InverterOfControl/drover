using System.Net.Http.Headers;
using System.Text;

namespace Drover.Api.Handler
{
  public class AuthHandler : HttpClientHandler
  {
    private readonly string _username;
    private readonly string _password;

    public AuthHandler(string username,
        string password)
    {
      _username = username;
      _password = password;
    }

    protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
      request.Headers.Authorization = new AuthenticationHeaderValue("Basic",
          Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(
              $"{_username}:{_password}")));

      return await base.SendAsync(request, cancellationToken)
          .ConfigureAwait(false);
    }
  }
}
