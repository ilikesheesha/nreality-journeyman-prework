using System;
using System.Collections.Generic;

namespace Journeyman.Pre.FizzBuzz
{
    public class NumberListFactory
    {
        public static List<int> CreateNumberList(int lowerBound, int upperBound, int increment)
        {
            if (lowerBound > upperBound)
                throw new ArgumentOutOfRangeException("lowerBound", "The lowerBound is greater than the upperBound.");
            if (increment < 1)
                throw new ArgumentOutOfRangeException("increment", "The increment cannot be less than 1.");

            var numberList = new List<int>();
            for (var i = lowerBound; i <= upperBound; i += increment)
            {
                numberList.Add(i);
            }

            return numberList;
        }
    }
}
