using FluentAssertions;
using System.Threading.Tasks;
using TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers;
using Xunit;

namespace TechnicalChallenge.Tests.UnitTests.Queries.v1
{
    public class GetNumbersDividersQueryHandlerTests
    {
        [Fact(DisplayName = "Should Be Success When Call GetNumbersDividersQueryHandler With Valid Values")]
        public async Task ShouldBeSuccessWhenCallGetNumbersDividersQueryHandlerWithValidValues()
        {
            var query = new GetNumbersDividersQuery {Number = 45};
            var model = await new GetNumbersDividersQueryHandler().Handle(query, default);
            model.PrimeNumbers.Count.Should().Be(3);
        }
    }
}