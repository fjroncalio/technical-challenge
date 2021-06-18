using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers
{
    public class GetNumbersDividersQueryHandler : IRequestHandler<GetNumbersDividersQuery, GetNumbersDividersQueryModel>
    {
        public async Task<GetNumbersDividersQueryModel> Handle(GetNumbersDividersQuery request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var timer = new Stopwatch();
                timer.Start();

                GetNumbersDividersQueryModel result = request.Number;

                result.AddTimeToExecute(timer.Elapsed);
                timer.Stop();

                return result;
            }, cancellationToken);   
        }
    }
}