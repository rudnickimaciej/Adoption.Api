using Adoption.Application.Pets.DTO;
using Adoption.Shared.Abstractions.Command;

namespace Adoption.Application.Pets.Commands
{
    public record CreatePet(string name, int breed, DateTime birthdate, string description):ICommand
    {
    }
}
