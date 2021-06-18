using System.Collections.Generic;

namespace TechnicalChallenge.Domain.Helpers.v1
{
    public static class NumberDividerExtensions
    {
        public static Dictionary<int, bool> GetDividersInNumber(this int number)
        {
            var result = new Dictionary<int, bool>();
            var minimumDivisor = number / 2;

            for (var i = 1; i < minimumDivisor; i++)
            {
                if (number % i == 0)
                    result.Add(i, i.IsPrimeNumber());
            }

            result.Add(number, number.IsPrimeNumber());

            return result;
        }

        public static Dictionary<int, bool> GetDividersInNumber(this int number, int minimumDivisor)
        {
            var result = new Dictionary<int, bool>();

            for (var i = 1; i < minimumDivisor; i++)
            {
                if (number % i == 0)
                    result.Add(i, i.IsPrimeNumber());
            }

            return result;
        }

        public static bool IsPrimeNumber(this int number) =>
            number == 1 || number.GetDividersInNumber(number).Count == 1;
    }
}