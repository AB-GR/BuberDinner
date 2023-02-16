using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Application.Services;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection(JwtSettings.SectionName));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
