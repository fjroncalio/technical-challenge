using System;
using FluentAssertions;
using TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers;
using Xunit;

namespace TechnicalChallenge.Tests.UnitTests.Queries.v1
{
    public class GetNumbersDividersQueryModelTests
    {
        [Fact(DisplayName = "Should Be Success When Create Class Using Implicit Operator")]
        public void ShouldBeSuccessWhenCreateClassUsingImplicitOperator()
        {
            GetNumbersDividersQueryModel query = 45;
            query.PrimeNumbers.Count.Should().Be(3);
        }

        [Fact(DisplayName = "Should Be Success When Create Class Using Constructor")]
        public void ShouldBeSuccessWhenCreateClassUsingConstructor()
        {
            var query = new GetNumbersDividersQueryModel(45);
            query.PrimeNumbers.Count.Should().Be(3);
        }

        [Fact(DisplayName = "Should Be Success When Call Method AddTimeToExecute")]
        public void ShouldBeSuccessWhenCallMethodAddTimeToExecute()
        {
            GetNumbersDividersQueryModel query = 45;
            query.AddTimeToExecute(new TimeSpan(ticks: 10));
            query.TimeToExecute.Ticks.Should().Be(10);
        }
    }
}
