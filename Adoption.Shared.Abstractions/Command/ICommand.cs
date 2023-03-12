using MediatR;

namespace Adoption.Shared.Abstractions.Command
{
    public interface ICommand: IRequest
    {
        Guid Id { get; }
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
        Guid Id { get; }
    }
}
