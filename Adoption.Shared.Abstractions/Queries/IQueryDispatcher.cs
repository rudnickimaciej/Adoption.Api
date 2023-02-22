﻿namespace Adoption.Shared.Abstractions.Queries
{
    public interface IQueryDispatcher
    {
        Task<TResult> DispatchAsync<TResult> (IQuery<TResult> query);
    }
}
