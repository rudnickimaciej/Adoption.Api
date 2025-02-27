﻿//using Adoption.Shared.Abstractions.Command;
//using Adoption.Shared.Abstractions.Queries;
//using Microsoft.Extensions.DependencyInjection;

//namespace Adoption.Shared.Queries
//{
//    internal sealed class InMemoryQueryDispatcher : IQueryDispatcher
//    {
//        private readonly IServiceProvider _serviceProvider;

//        public InMemoryQueryDispatcher(IServiceProvider serviceProvider) =>
//            _serviceProvider = serviceProvider;

//        public async Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query)
//        {
//            using var scope = _serviceProvider.CreateScope();

//            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
//            var handler = scope.ServiceProvider.GetRequiredService(handlerType);

//            return await (Task<TResult>)handlerType.GetMethod(nameof(IQueryHandler<IQuery<TResult>, TResult>.HandleAsync))?
//                .Invoke(handler, new[] { query });
//        }
//    }
//}
