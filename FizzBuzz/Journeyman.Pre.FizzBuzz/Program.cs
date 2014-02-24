
using System;

namespace Journeyman.Pre.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = new ArgumentsHandler(args);

            if (arguments.IsValid)
            {
                var numberList = NumberListFactory.CreateNumberList(arguments.LowerBound, arguments.UpperBound, 1);
                foreach (var i in numberList)
                {
                    Console.WriteLine(i.FizzBuzz());
                }
            }
            else
            {
                Console.WriteLine(arguments.Help);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
