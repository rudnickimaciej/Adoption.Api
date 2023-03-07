namespace Adoption.Auth.Authentication
{
    public record LoginRequest(
        string Email,
        string Password,
        bool RememberMe);
}
