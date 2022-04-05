using Drover.Api.Factories;
using Drover.Sample;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

IConfiguration config = builder.Build();

var bugherdConfig = config.GetSection("BugherdConfig").Get<BugherdConfig>();

var connection = ConnectionFactory.CreateConnection(bugherdConfig.ApiKey, bugherdConfig.BaseUri);


var projectService = connection.CreateProjectService();

var projects = await projectService.GetProjects();
Console.WriteLine(string.Join(",", projects.Select(p => p.Name)));

var attachmentService = connection.CreateAttachmentService();

string source = "test.png";
long projectid = 265833;
long taskId = 14973247;
long attachmentId = 1956457;

await attachmentService.DeleteAttachment(projectid, taskId, attachmentId);


Console.ReadKey();