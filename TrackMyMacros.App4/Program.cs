using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using TrackMyMacros.App4;
using TrackMyMacros.App4.Interfaces;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.Services.DailyLimitsDataService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddBlazoredLocalStorage();

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<DayDataService>();
builder.Services.AddSingleton<IFoodDataService,FoodDataService>();
builder.Services.AddSingleton<IDailyLimitsDataService,DailyLimitsDataService>();
builder.Services.AddScoped<IUomDataService, UomDataService>();
builder.Services.AddScoped<IFoodComboDataService, FoodComboDataService>();
builder.Services.AddScoped<ILogDataService, LogDataService>();
builder.Services.AddScoped<IGenericDataService, GenericDataService>();
//
builder.Services.AddScoped<DialogService>();

builder.Services.AddSingleton<IFoodDataRepository, FoodDataRepository>();

builder.Services.AddScoped<DialogService>();



await builder.Build().RunAsync();