using Adoption.Shared.Abstractions.Command;
using MediatR;

namespace Adoption.Application.Offerts.Commands.AddOffert
{
    public class AddOffertCommand : CommandBase<Unit>
    {
        public Guid PetId { get; }
        public string Description { get;}

    }
}
