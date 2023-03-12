namespace Adoption.Application.Common.Services.Authentication
{
    public record AuthenticationResult(
        Guid id,
        string UserName,
        string Email,
        string Token
        );
}
