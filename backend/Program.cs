
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Trace;
using OpenTelemetry.Resources;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenTelemetry()
    .WithTracing(tracerProviderBuilder =>
    {
        tracerProviderBuilder
            .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("hrms-backend"))
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddOtlpExporter(options =>
            {
                options.Endpoint = new Uri("https://otlp.nr-data.net:4317");
                options.Headers = "api-key=<YOUR_NEW_RELIC_KEY>";
            });
    });

var app = builder.Build();

app.MapGet("/api/employees", () =>
{
    return new[] {
        new { Id = 1, Name = "John Doe" },
        new { Id = 2, Name = "Jane Smith" }
    };
});

app.Run();
