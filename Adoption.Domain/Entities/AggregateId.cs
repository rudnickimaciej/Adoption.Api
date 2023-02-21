﻿using Adoption.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Entities
{
    public record AggregateId
    {
        public Guid Value { get; }

        public AggregateId() : this(Guid.NewGuid()) { }

        public AggregateId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new InvalidAggregateIdException(value);
            }
            Value = value;
        }

        public static AggregateId Create() => new(Guid.NewGuid());

        public static implicit operator Guid(AggregateId id)=> id.Value;
        public static implicit operator AggregateId(Guid id) => new(id);

        public override string ToString() => Value.ToString();
    }
}
