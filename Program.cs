using BugFreeBroccoli;
using BugFreeBroccoli.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Register your movie service (singleton or scoped depending on needs)
builder.Services.AddSingleton<IMovieReviewService, MovieReviewService>();

await builder.Build().RunAsync();
