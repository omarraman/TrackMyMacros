using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Scrutor;
using TrackMyMacros.Application;
using TrackMyMacros.Application.Utils;
using TrackMyMacros.Persistance;

namespace TrackMyMacros.Api
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(
        this WebApplicationBuilder builder, IConfiguration configuration)
        {
            AddSwagger(builder.Services);
            
            builder.Services.AddLogging(config =>
            {
                config.AddDebug();
                config.AddConsole();
                //etc
            });

            // Additional code to register the ILogger as a ILogger<T> where T is the Startup class
            builder.Services.AddSingleton(typeof(ILogger), typeof(Logger<Program>)); 
            builder.Services.AddApplicationServices();
            // builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddPersistenceServices(builder.Configuration);

            
            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            


            builder.Services.AddDecoratorServices(typeof(Program));

            var connectionString = configuration.GetConnectionString("MacrosConnectionString");
            builder.Services.AddSingleton(new ConnectionString(connectionString));


            return builder.Build();

        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TrackMyMacros API");
                });
            }

            app.UseHttpsRedirection();

            //app.UseRouting();
            
            app.UseAuthentication();

            // app.UseCustomExceptionHandler();

            app.UseCors("Open");

            app.UseAuthorization();

            app.MapControllers();

            return app;

        }
        private static void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                // c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                // {
                //     Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                //       Enter 'Bearer' [space] and then your token in the text input below.
                //       \r\n\r\nExample: 'Bearer 12345abcdef'",
                //     Name = "Authorization",
                //     In = ParameterLocation.Header,
                //     Type = SecuritySchemeType.ApiKey,
                //     Scheme = "Bearer"
                // });

                // c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                //   {
                //     {
                //       new OpenApiSecurityScheme
                //       {
                //         Reference = new OpenApiReference
                //           {
                //             Type = ReferenceType.SecurityScheme,
                //             Id = "Bearer"
                //           },
                //           Scheme = "oauth2",
                //           Name = "Bearer",
                //           In = ParameterLocation.Header,
                //
                //         },
                //         new List<string>()
                //       }
                //     });~

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "TrackMyMacros API",

                });

            });
        }

        public static async Task ResetDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            // try
            // {
                var context = scope.ServiceProvider.GetService<AppDbContext>();
                if (context != null)
                {
                    // await context.Database.EnsureDeletedAsync();
                    await context.Database.MigrateAsync();
                    
                    // await context.Database.EnsureCreatedAsync();
                }
            // }
            // catch (Exception ex)
            // {
            //     var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
            //     logger.LogError(ex, "An error occurred while migrating the database.");
            // }
        }
        
        public static void AddDecoratorServices(this IServiceCollection services,Type t)
        {
            services.Scan(scan =>
            {
                scan.FromAssembliesOf(t)
                    .RegisterHandlers(typeof(IRequestHandler<,>));
            });

            services.Decorate(typeof(IRequestHandler<,>), typeof(LoggingDecorator<,>));
        }
        
        public static IImplementationTypeSelector RegisterHandlers(this IImplementationTypeSelector selector, Type type)
        {
            return selector.AddClasses(c =>
                    c.AssignableTo(type)
                        .Where(t => t != typeof(LoggingDecorator<,>))
                )
                .UsingRegistrationStrategy(RegistrationStrategy.Append)
                .AsImplementedInterfaces()
                .WithTransientLifetime();
        }
    }
}