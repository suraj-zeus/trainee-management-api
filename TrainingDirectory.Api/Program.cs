using TrainingDirectory.Api.Services;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddControllers();



builder.Services.AddScoped<IDirectoryService, DirectoryService>();

// Register the core health check services
builder.Services.AddHealthChecks();


var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();




app.MapGet("/", () =>
{
    return "Hello World!";
});




// 1. Liveness Endpoint
app.MapHealthChecks("/health/live", new HealthCheckOptions
{
    Predicate = _ => false 
});

// 2. Readiness Endpoint
app.MapHealthChecks("/health/ready", new HealthCheckOptions
{
    Predicate = _ => true 
});






app.Run();

