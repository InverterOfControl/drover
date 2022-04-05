# Drover

A simple .NET Wrapper for the Bugherd REST-API.


Currently the following Endpoints are covered:

|Endpoint|
|--------|
|Organization|
|Users|
|Projects|
|Tasks|
|Columns|
|Comments|
|Attachments|

## Getting started


### Install the NuGet-Package

In order to use the package it must be installed via NuGet:

```
Install-Package Drover.Api
```

### Using the Library


First you need to create the connection via the `ConnectionFactory`:

```csharp
var connection = ConnectionFactory.CreateConnection("YourApiKey", "https://www.bugherd.com");
```

Next the service for the Operation you want to execute has to be created:

```csharp
var projectService = connection.CreateProjectService();

var projects = await projectService.GetProjects();
```
