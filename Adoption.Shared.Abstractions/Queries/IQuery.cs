using MediatR;

namespace Adoption.Shared.Abstractions.Queries
{
    public interface  IQuery<out TResult> : IRequest<TResult>
    {
    }
}
