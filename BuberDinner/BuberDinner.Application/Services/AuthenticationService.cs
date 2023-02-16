using BuberDinner.Application.Common.Interfaces;

namespace BuberDinner.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string email, string password)
        {
            var userId = Guid.NewGuid();
            return new AuthenticationResult(userId, "firstName", "lastName", email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }
    }
}
