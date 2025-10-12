using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Net.Http; 

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add this line to register HttpClient
builder.Services.AddScoped(sp => new HttpClient { 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();