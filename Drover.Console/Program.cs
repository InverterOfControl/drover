using Drover.Api.Factories;
using Drover.Api.Services;
using Drover.Sample;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

IConfiguration config = builder.Build();

var bugherdConfig = config.GetSection("BugherdConfig").Get<BugherdConfig>();

var connection = ConnectionFactory.CreateConnection(bugherdConfig.ApiKey, bugherdConfig.BaseUri);

var projectService = new ProjectService(connection);

var projects = await projectService.GetProjects();

Console.WriteLine(string.Join(",", projects.Select(p => p.Name)));

var gasagProject = projects.FirstOrDefault(p => p.Name == "Gasag.de");

if(gasagProject is not null)
{
  var tasksservice = new TaskService(connection);

  var tasks = await tasksservice.GetProjectTasks(gasagProject.Id.Value);

  Console.WriteLine(string.Join(",", tasks.Select(task => task.Description)));
}

//var organisationService = new OrganisationService(connection);

//var organisation = await organisationService.GetOrganisation();

//Console.WriteLine("Organisation: " + organisation.Name);

//var usersService = new UsersService(connection);

//var users = await usersService.GetUsers();

//if(users.Count > 0){
//    Console.WriteLine(users.FirstOrDefault()?.DisplayName);
//}

Console.ReadKey();