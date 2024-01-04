

using Webdock.Factory;
using Webdock.Models.Configuration;
using Webdock.Services.Account;
using Webdock.Services.Snapshot;
using Webdock.Services;
using Webdock.Extensions;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebdock(config => {
    config.AuthorizationToken = builder.Configuration.GetValue<string>("WebdockSettings:AuthorizationToken");
});

// Configure services here
builder.Services.AddSingleton<WebdockHttpClientFactory>();
builder.Services.AddScoped<IPingService, PingService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ISnapshotService,SnapshotService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowPrometheus", policy =>
    {
        policy.WithOrigins("http://host.docker.internal:51194") // Adjust the port 
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});





var app = builder.Build();

app.UseCors("AllowPrometheus");

// Prometheus metrics endpoint
app.UseHttpMetrics();  // Adds Prometheus metrics on the HTTP request pipeline

app.MapGet("/ping", async (IPingService pingService) =>
{
    try
    {
        var result = await pingService.GetPingAsync();
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

app.MapGet("/account/accountInformation", async (IAccountService accountService) =>
{
    try
    {
        var accountDetails = await accountService.GetAccountInformation();
        return Results.Ok(accountDetails);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});



app.MapMetrics();  // Serves metrics at /metrics endpoint

app.Run();
