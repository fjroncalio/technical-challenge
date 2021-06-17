using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace TechnicalChallenge.Api.Controllers
{
    [ApiController]
    [Route("api/v1/numbers")]
    public class NumberController : ControllerBase
    {
        private readonly ILogger<NumberController> _logger;

        public NumberController(ILogger<NumberController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{number}/dividers")]
        public async Task GetDividers(int number)
        {
            throw new NotImplementedException();
        }
    }
}