using BlazorServerLAP.Models.Configurations;
using BlazorServerLAP.Services;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IServiceCollection sp = builder.Services;
string? conn = configuration.GetConnectionString("connectionString");

sp.AddDbContext<ApplicationDBContext>(o => o.UseSqlServer(conn));
sp.AddRazorPages();
sp.AddServerSideBlazor();
sp.AddScoped<ICampusService, CampusService>();
sp.AddLogging();

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
