using Adoption.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Domain.Exceptions
{
    public sealed class ApplicationAlreadyAddedException : CustomException
    {
        public Application Application { get; }
        public ApplicationAlreadyAddedException(Application application) : base($"Application has already be sent to this Offert")
        {
            Application = application;
        }
    } 
}
