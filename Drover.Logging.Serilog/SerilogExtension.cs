using Drover.Api.Logging;
using Microsoft.Extensions.Logging;
using Serilog;
using External = Serilog;

namespace Drover.Logging.Serilog.Extensions
{
    public static class SerilogExtension
    {
        public static External.ILogger AddToDrover(this External.ILogger logger)
        {
            var factory = new LoggerFactory();
            factory.AddSerilog(logger);

            LogProvider.SetLogFactory(factory);

            return logger;
        }
    }
}
