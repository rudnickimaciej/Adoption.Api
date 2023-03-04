using Adoption.Domain.Applications.Entities;
using Adoption.Shared.Abstractions.Exceptions;


namespace Adoption.Domain.Applications.Exceptions
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
