using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Net.Http; 
using MyApplication.Client;

Console.WriteLine("Starting app...");
var builder = WebAssemblyHostBuilder.CreateDefault(args);

Console.WriteLine("Builder created...");

//Eigentlich sollte das #app sein
builder.RootComponents.Add<App>("#app");
// Add this line to register HttpClient
builder.Services.AddScoped(sp => new HttpClient { 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

Console.WriteLine("HttpClient registered...");

builder.Services.AddMudServices();

Console.WriteLine("MudServices added...");

await builder.Build().RunAsync();

Console.WriteLine("App running!");

