using FluentAssertions;
using TechnicalChallenge.Domain.Helpers.v1;
using Xunit;

namespace TechnicalChallenge.Tests.UnitTests.Helpers.v1
{
    public class NumberDividerExtensionsTests
    {
        [Theory(DisplayName = "Should Be True When Pass Prime Number In Method IsPrimeNumber")]
        [InlineData(1), InlineData(2), InlineData(5), InlineData(19)]
        public void ShouldBeTrueWhenPassPassPrimeNumberInIsPrimeNumber(int number)
        {
            number.IsPrimeNumber().Should().BeTrue();
        }

        [Theory(DisplayName = "Should Be False When Pass Non Prime Number In Method IsPrimeNumber")]
        [InlineData(10), InlineData(4), InlineData(100)]
        public void ShouldBeFalseWhenPassNonPrimeNumberInMethodIsPrimeNumber(int number)
        {
            number.IsPrimeNumber().Should().BeFalse();
        }

        [Fact(DisplayName = "Should Be Contains Six Elements When Pass Number 45 In Method GetDividersInNumber")]
        public void ShouldBeContainsSixElementsWhenPassNumber45InMethodGetDividersInNumber()
        {
            45.GetDividersInNumber().Count.Should().Be(6);
        }

        [Fact(DisplayName = "Should Be Contains Five Elements When Pass Number 45 And MinimumDivisor 40 In Method GetDividersInNumber")]
        public void ShouldBeContainsFiveElementsWhenPassNumber45AndMinimumDivisor40InMethodGetDividersInNumber()
        {
            45.GetDividersInNumber(40).Count.Should().Be(5);
        }
    }
}