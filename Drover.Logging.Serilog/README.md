# Drover
## Logging.Serilog..Extensions

A simple .NET Wrapper for the Bugherd REST-API.

This package provides an extension to incorporate Drover-logs into your Serilog-Logger.

## Getting started


### Install the NuGet-Package

In order to use the package it must be installed via NuGet:

```
Install-Package Drover.Logging.Extensions.Serilog
```

### Using the Library


Simply append the extension-method to your serilog initialization.
It could look something like this:

```csharp
new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger()
    .AddToDrover();
```

The important part is the `.AddToDrover()` call.

