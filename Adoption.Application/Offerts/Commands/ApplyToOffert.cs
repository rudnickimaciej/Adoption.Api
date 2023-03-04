using Adoption.Shared.Abstractions.Command;

namespace Adoption.Application.Commands
{
    public record ApplyToOffert(Guid OffertId, string Description):ICommand
    {
    }
}
