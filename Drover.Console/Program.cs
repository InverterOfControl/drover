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

var organisationService = new OrganisationService(connection);

var organisation = await organisationService.GetOrganisation();

Console.WriteLine("Organisation: " + organisation.Name);

var usersService = new UsersService(connection);

var users = await usersService.GetUsers();


Console.WriteLine(users.FirstOrDefault().DisplayName);

Console.ReadKey();