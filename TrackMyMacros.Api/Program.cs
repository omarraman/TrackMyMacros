using AutoMapper;
using Serilog;
using TrackMyMacros.Api;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Track My Macros API starting");
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, loggerConfiguration) => loggerConfiguration
     .WriteTo.Console()
     .WriteTo.File
     (
         "log.txt", // <<<<<<<<<<<<<<<<<<<<<<
         rollingInterval: RollingInterval.Day,
         retainedFileCountLimit: 7
     )
     .ReadFrom.Configuration(context.Configuration));



var app = builder
    .ConfigureServices(builder.Configuration)
    .ConfigurePipeline();


app.UseSerilogRequestLogging();

await app.ResetDatabaseAsync();


app.Run();

public partial class Program { }