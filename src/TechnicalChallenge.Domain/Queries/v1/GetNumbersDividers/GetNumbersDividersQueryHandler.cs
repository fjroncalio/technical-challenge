using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using TechnicalChallenge.Domain.Core;

namespace TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers
{
    public class GetNumbersDividersQueryHandler : RetryPollicy<GetNumbersDividersQueryHandler>, IRequestHandler<GetNumbersDividersQuery, GetNumbersDividersQueryModel>
    {
        public GetNumbersDividersQueryHandler(ILogger<GetNumbersDividersQueryHandler> logger)
            : base(logger) { }

        public async Task<GetNumbersDividersQueryModel> Handle(GetNumbersDividersQuery request, CancellationToken cancellationToken)
        {
            return await HandleAsync(async () =>
            {
                var timer = new Stopwatch();
                timer.Start();

                GetNumbersDividersQueryModel result = request.Number;

                result.AddTimeToExecute(timer.Elapsed);
                timer.Stop();

                return result;
            });
        }
    }
}