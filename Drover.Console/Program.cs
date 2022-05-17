using Drover.Api.Factories;
using Drover.Api.Logging;
using Drover.Logging.Serilog.Extensions;
using Drover.Sample;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

var log = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger()
    .AddToDrover();


log.Information("test");

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

IConfiguration config = builder.Build();

var bugherdConfig = config.GetSection("BugherdConfig").Get<BugherdConfig>();

var connection = ConnectionFactory.CreateConnection(bugherdConfig.ApiKey, bugherdConfig.BaseUri);


var projectService = connection.CreateProjectService();

var projects = await projectService.GetProjects();
Console.WriteLine(string.Join(",", projects.Select(p => p.Name)));

Console.ReadKey();