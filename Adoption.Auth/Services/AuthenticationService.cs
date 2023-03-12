using Adoption.Application.Common.Services.Authentication;
using Adoption.Auth.EF.Contexts;
using Adoption.Auth.Entities;
using Adoption.Auth.Exceptions;
using Adoption.Auth.Repositiories;
using Adoption.Shared.Abstractions.Exceptions;
using Microsoft.AspNetCore.Identity;
using OneOf;

namespace Adoption.Auth.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;
        private UserDbContext _userDbContext { get; set; }
        private UserManager<IdentityUser> _userManager { get; set; }

        public AuthenticationService(
            IJwtTokenGenerator jwtTokenGenerator, 
            IUserRepository userRepository,
            UserDbContext userDbContext, 
            UserManager<IdentityUser> userManager)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
            _userDbContext = userDbContext;
            _userManager = userManager;
        }


        public async Task<OneOf<AuthenticationResult, InvalidCredentialsException>> Login(string email, string password)
        {
            var user = await _userRepository.GetByEmailAsync(email);

            if (user?.Password != password)
            {
                return new InvalidCredentialsException();
            }
            var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);

            return new AuthenticationResult(
                user.Id,
                user.FirstName,
                user.Email,
                token);
        }

        public async Task<OneOf<AuthenticationResult, CustomException>> Register(string firstName, string lastName, string email, string password)
        {

            var result = await _userManager.CreateAsync(new IdentityUser()
            {
                Email = email,
                UserName = firstName
            }, password);

            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }

            throw new Exception("");

            // Create user (generat unique ID)
            //Create JWT Token
            //var token = _jwtTokenGenerator.GenerateToken(newUser.Id, firstName, lastName);

            //return new AuthenticationResult(
            //    newUser.Id,
            //    firstName,
            //    lastName,
            //    email,
            //    token);
        }
    }
}
