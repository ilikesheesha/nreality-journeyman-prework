


using System;

namespace Journeyman.Pre.FizzBuzz
{
    public class ArgumentsHandler
    {
        public ArgumentsHandler(string[] args)
        {
            LowerBound = 1;
            UpperBound = 100;
            IsValid = false;

            if (args == null)
            {
                IsValid = true;
                return;
            }

            if (args.Length == 0)
            {
                IsValid = true;
                return;
            }

            if (args.Length == 2)
            {
                var lowerBound = 0;
                var upperBound = 0;

                if (int.TryParse(args[0], out lowerBound) == false)
                    return;

                if (int.TryParse(args[1], out upperBound) == false)
                    return;

                if (lowerBound > upperBound)
                    return;

                LowerBound = lowerBound;
                UpperBound = upperBound;
                IsValid = true;
            }
        }

        public int UpperBound { get; private set; }

        public int LowerBound { get; private set; }

        public bool IsValid { get; private set; }

        public string Help
        {
            get
            {
                return Environment.NewLine +
                    "Prints out a sequence of numbers between a lower bound and upper bound. " + Environment.NewLine +
                    "  The default is 1 - 100. " + Environment.NewLine +
                    "  For numbers that are multiples of 3 it prints 'Fizz'. " + Environment.NewLine +
                    "  For numbers that are multiples of 5 it prints 'Buzz'. " + Environment.NewLine +
                    "  For numbers that are both multiples of 3 and 5 it prints out FizzBuzz" + Environment.NewLine + Environment.NewLine +
                    "USAGE:" + Environment.NewLine +
                    "Journeyman.Pre.FizzBuzz [lowerBound] [upperBound]" + Environment.NewLine +
                    "  lowerBound  Optional parameter that must be a whole number. " + Environment.NewLine +
                    "              It is the first number in the sequence of numbers." + Environment.NewLine +
                    "              The default is 1." + Environment.NewLine +
                    "  upperBound  Optional parameter that must be a whole number. " + Environment.NewLine +
                    "              It is the last number in the sequence of numbers." + Environment.NewLine +
                    "              The default is 100." + Environment.NewLine +
                    "  Note:  1. Both [lowerBound] and [upperBound] must be supplied together." + Environment.NewLine +
                    "         2. [lowerBound] must be less than [upperBound]";
            }
        }
    }
}
