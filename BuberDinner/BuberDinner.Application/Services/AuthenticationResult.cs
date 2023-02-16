using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services
{
    public record AuthenticationResult(User User, string Token);
}