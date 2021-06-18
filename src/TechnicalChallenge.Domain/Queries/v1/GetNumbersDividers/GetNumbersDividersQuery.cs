using MediatR;

namespace TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers
{
    public class GetNumbersDividersQuery : IRequest<GetNumbersDividersQueryModel>
    {
        public int Number { get; set; }
    }
}