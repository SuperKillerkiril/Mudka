using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using UserTaskManager.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddScoped<MyUserTaskService>();

await builder.Build().RunAsync();