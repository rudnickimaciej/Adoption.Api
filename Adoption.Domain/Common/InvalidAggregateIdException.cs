using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Exceptions
{
   public class InvalidAggregateIdException: CustomException
    {
        public Guid Id { get; }
        public InvalidAggregateIdException(Guid id):base($"Invalid aggregate id: {id}")
        {
            Id = id;
        }
    }
}
