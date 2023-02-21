using Adoption.Shared.Abstractions.Command;

namespace Adoption.Application.Commands
{
    public record CreateOffert(Guid PetId, string Description):ICommand
    {
    }
}
