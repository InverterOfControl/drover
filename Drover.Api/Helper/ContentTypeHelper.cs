using Microsoft.AspNetCore.StaticFiles;

namespace Drover.Api.Helper
{
  internal static class ContentTypeHelper
  {
    internal static string GuessContentType(string fileName)
    {
      var provider = new FileExtensionContentTypeProvider();
      string contentType;
      if (!provider.TryGetContentType(fileName, out contentType))
      {
        contentType = "application/octet-stream";
      }

      return contentType;
    }
  }
}
