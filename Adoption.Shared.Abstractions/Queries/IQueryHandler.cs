using MediatR;

namespace Adoption.Shared.Abstractions.Queries
{
    public interface IQueryHandler<in TQuery, TResult>:IRequestHandler<TQuery, TResult> where TQuery : class, IQuery<TResult>
    {
        
    }
}
