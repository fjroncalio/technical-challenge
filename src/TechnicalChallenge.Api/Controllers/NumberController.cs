using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers;

namespace TechnicalChallenge.Api.Controllers
{
    [ApiController]
    [Route("api/v1/numbers")]
    public class NumberController : ControllerBase
    {
        private readonly IMediator _bus;
        private readonly ILogger<NumberController> _logger;

        public NumberController(
            IMediator bus,
            ILogger<NumberController> logger
            )
        {
            _bus = bus;
            _logger = logger;
        }

        [HttpGet("{Number}/dividers")]
        public async Task<ObjectResult> GetDividers([FromRoute] GetNumbersDividersQuery query)
        {
            try
            {
                return Ok(await _bus.Send(query));
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error in {nameof(NumberController)}.GetDividers Flow.");
                return Problem("Some problem flow, please retry again in a few minutes.");
            }
        }
    }
}