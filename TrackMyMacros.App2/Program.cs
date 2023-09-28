using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Polly;
using Polly.Caching;
using Polly.Registry;
using Radzen;
using TrackMyMacros.App2;
using TrackMyMacros.App2.Services;

IPolicyRegistry<string> _myRegistry;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<DayDataService>();
builder.Services.AddSingleton<IFoodDataService,FoodDataService>();
builder.Services.AddScoped<IUomDataService, UomDataService>();

builder.Services.AddScoped<DialogService>();

builder.Services.AddSingleton<IFoodDataRepository, FoodDataRepository>();

// builder.Services.AddMemoryCache();
// builder.Services.AddSingleton<Polly.Caching.IAsyncCacheProvider, Polly.Caching.Memory.MemoryCacheProvider>();
//
// builder.Services.AddSingleton<Polly.Registry.IReadOnlyPolicyRegistry<string>, Polly.Registry.PolicyRegistry>((serviceProvider) =>
// {
//     PolicyRegistry registry = new PolicyRegistry();
//     registry.Add("myCachePolicy", 
//         Policy.CacheAsync<HttpResponseMessage>(
//             serviceProvider
//                 .GetRequiredService<IAsyncCacheProvider>()
//                 .AsyncFor<HttpResponseMessage>(),
//             TimeSpan.FromMinutes(5)));
//     return registry;
// });

await builder.Build().RunAsync();