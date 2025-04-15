using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorFrontEnd;
using System.Text.Json;

// Create a WebAssemblyHostBuilder instance to configure the Blazor WebAssembly app
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add the main App component to the root of the application
builder.RootComponents.Add<App>("#app");

// Add the HeadOutlet component for managing <head> content dynamically
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register an HttpClient service with a base address for API calls
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:5001") // Base API URL
});

// Build and run the application
await builder.Build().RunAsync();

/*
Copilot Contribution:
1. Suggested the use of `WebAssemblyHostBuilder.CreateDefault(args)` to initialize the app, ensuring proper configuration for a Blazor WebAssembly project.
2. Recommended adding `HeadOutlet` to manage dynamic <head> content, which is a best practice in Blazor projects.
3. Provided an efficient way to register `HttpClient` with a scoped lifetime and a base address, streamlining API communication setup.
4. Improved efficiency by generating boilerplate code for setting up the Blazor WebAssembly app, saving time and reducing potential errors.
*/