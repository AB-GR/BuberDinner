using BuberDinner.Application.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
