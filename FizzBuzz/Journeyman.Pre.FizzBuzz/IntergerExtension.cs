
using System.Globalization;

namespace Journeyman.Pre.FizzBuzz
{
    public static class IntergerExtension
    {
        public static string FizzBuzz(this int value)
        {
            if (value == 0) return value.ToString(CultureInfo.InvariantCulture);
            if ((value % 15) == 0) return "FizzBuzz";
            if ((value % 5) == 0) return "Buzz";
            if ((value % 3) == 0) return "Fizz";
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
