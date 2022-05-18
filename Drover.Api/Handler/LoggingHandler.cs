using Drover.Api.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Drover.Api.Handler
{
  public class HttpLoggingHandler : DelegatingHandler
  {
    public HttpLoggingHandler(HttpMessageHandler innerHandler = null)
        : base(innerHandler ?? new HttpClientHandler())
    { }
    async protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      var req = request;
      var id = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
      
      var msg = $"[{id} -   Request]";
      var logger = LogProvider.GetLogger("HttpLogger");

      logger.LogDebug($"{msg}========Start==========");
      logger.LogDebug($"{msg} {req.Method} {req.RequestUri.PathAndQuery} {req.RequestUri.Scheme}/{req.Version}");
      logger.LogDebug($"{msg} Host: {req.RequestUri.Scheme}://{req.RequestUri.Host}");

      foreach (var header in req.Headers)
        logger.LogDebug($"{msg} {header.Key}: {string.Join(", ", header.Value)}");

      if (req.Content != null)
      {
        foreach (var header in req.Content.Headers)
          logger.LogDebug($"{msg} {header.Key}: {string.Join(", ", header.Value)}");

        if (req.Content is StringContent || this.IsTextBasedContentType(req.Headers) || this.IsTextBasedContentType(req.Content.Headers))
        {
          var result = await req.Content.ReadAsStringAsync();

          logger.LogDebug($"{msg} Content:");
          logger.LogDebug($"{msg} {string.Join("", result.Cast<char>().Take(255))}...");

        }
      }

      var start = DateTime.Now;

      var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

      var end = DateTime.Now;

      logger.LogDebug($"{msg} Duration: {end - start}");
      logger.LogDebug($"{msg}==========End==========");

      msg = $"[{id} - Response]";
      logger.LogDebug($"{msg}=========Start=========");

      var resp = response;

      logger.LogDebug($"{msg} {req.RequestUri.Scheme.ToUpper()}/{resp.Version} {(int)resp.StatusCode} {resp.ReasonPhrase}");

      foreach (var header in resp.Headers)
        logger.LogDebug($"{msg} {header.Key}: {string.Join(", ", header.Value)}");

      if (resp.Content != null)
      {
        foreach (var header in resp.Content.Headers)
          logger.LogDebug($"{msg} {header.Key}: {string.Join(", ", header.Value)}");

        if (resp.Content is StringContent || this.IsTextBasedContentType(resp.Headers) || this.IsTextBasedContentType(resp.Content.Headers))
        {
          start = DateTime.Now;
          var result = await resp.Content.ReadAsStringAsync();
          end = DateTime.Now;

          logger.LogDebug($"{msg} Content:");
          logger.LogDebug($"{msg} {string.Join("", result.Cast<char>().Take(255))}...");
          logger.LogDebug($"{msg} Duration: {end - start}");
        }
      }

      logger.LogDebug($"{msg}==========End==========");
      return response;
    }

    readonly string[] types = new[] { "html", "text", "xml", "json", "txt", "x-www-form-urlencoded" };

    bool IsTextBasedContentType(HttpHeaders headers)
    {
      IEnumerable<string> values;
      if (!headers.TryGetValues("Content-Type", out values))
        return false;
      var header = string.Join(" ", values).ToLowerInvariant();

      return types.Any(t => header.Contains(t));
    }
  }
}
