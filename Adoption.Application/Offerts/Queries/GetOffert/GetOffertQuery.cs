using Adoption.Shared.Abstractions.Queries;

namespace Adoption.Application.Offerts.Queries.GetOffert
{
    public class GetOffertQuery : IQuery<OffertDto>
    {
        public Guid Id { get; set; }

        public GetOffertQuery(Guid id)
        {
            Id = id;
        }

    }
}
