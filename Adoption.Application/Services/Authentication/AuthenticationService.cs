using Adoption.Application.Common.Interfaces.Authentication;
using Adoption.Application.Exceptions;
using Adoption.Domain.Entities;
using Adoption.Domain.Repositiories;
using OneOf;

namespace Adoption.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<AuthenticationResult> Login(string email, string password)
        {
            var user = await _userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                throw new UserWithTheEmailNotExistsException();
            }
            if (user.Password != password)
            {
                //throw new WrongPasswordForUserException();
            }
            var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);

            return new AuthenticationResult(
                user.Id, 
                user.FirstName,
                user.LastName,
                user.Email, 
                token);
        }

        public async Task<OneOf<AuthenticationResult, UserAlreadyExistsException>> Register(string firstName, string lastName, string email, string password)
        {

            //Check if usr already exists
            var user = await _userRepository.GetByEmailAsync(email);
            if(user is not null)
            {
                throw new UserAlreadyExistsException();
            }

            var newUser = new User
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password
            };
            await _userRepository.AddAsync(newUser);
            // Create user (generat unique ID)
            //Create JWT Token
            var token = _jwtTokenGenerator.GenerateToken(newUser.Id, firstName, lastName);

            return new AuthenticationResult(
                newUser.Id,
                firstName, 
                lastName,
                email,
                token);
        }
    }
}
