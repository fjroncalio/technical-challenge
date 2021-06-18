using System;
using System.Collections.Generic;
using TechnicalChallenge.Domain.Helpers.v1;

namespace TechnicalChallenge.Domain.Queries.v1.GetNumbersDividers
{
    public class GetNumbersDividersQueryModel
    {
        public GetNumbersDividersQueryModel(int number)
        {
            foreach (var (key, value) in number.GetDividersInNumber())
                AddDivider(key, value);

            Dividers.Sort();
            PrimeNumbers.Sort();
        }

        public static implicit operator GetNumbersDividersQueryModel(int number)
        {
            return new (number);
        }

        public List<int> Dividers { get; private set; } = new List<int>();
        public List<int> PrimeNumbers { get ; private set; } = new List<int>();
        public TimeSpan TimeToExecute { get; private set; }

        private void AddDivider(int divider, bool isPrime)
        {
            Dividers.Add(divider);
            if (isPrime)
                PrimeNumbers.Add(divider);
        }

        public void AddTimeToExecute(TimeSpan timeToExecute) => 
            TimeToExecute = timeToExecute;
    }
}