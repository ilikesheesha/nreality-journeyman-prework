using Journeyman.Pre.FizzBuzz;
using System;
using Xunit;

namespace Journeyman.Pre.FizzBuzzTest
{
    public class IntegerExtensionTest
    {
        [Fact]
        public void FizzTest()
        {
            for (var i = -100; i <= 100; i++)
            {
                if (i == 0)

                    if (i != 0 && (i % 3) == 0 && (i % 15) != 0)
                        Assert.True(i.FizzBuzz() == "Fizz",
                            String.Format("Expected = Fizz, Actual = {0} (i: {1}, (i % 3) == 0: {2}, (i % 15) != 0: {3}", i.FizzBuzz(), i, (i % 3) == 0, (i % 15) != 0));

                if (i != 0 && (i % 3) != 0)
                    Assert.True(i.FizzBuzz() != "Fizz",
                        String.Format("Expected = {0}, Actual = Fizz", i.FizzBuzz()));
            }
        }

        [Fact]
        public void BuzzTest()
        {
            for (var i = -100; i <= 100; i++)
            {
                if (i != 0 && (i % 5) == 0 && (i % 15) != 0)
                    Assert.True(i.FizzBuzz() == "Buzz",
                        String.Format("Expected = Buzz, Actual = {0} (i: {1}, (i % 3) == 0: {2}, (i % 15) != 0: {3}", i.FizzBuzz(), i, (i % 3) == 0, (i % 15) != 0));

                if (i != 0 && (i % 5) != 0)
                    Assert.True(i.FizzBuzz() != "Buzz",
                        String.Format("Expected = {0}, Actual = Buzz", i.FizzBuzz()));
            }
        }

        [Fact]
        public void FizzBuzzTest()
        {
            for (var i = -100; i <= 100; i++)
            {
                if (i != 0 && (i % 15) == 0)
                    Assert.True(i.FizzBuzz() == "FizzBuzz",
                        String.Format("Expected = FizzBuzz, Actual = {0} (i: {1}, (i % 3) == 0: {2}, (i % 15) != 0: {3}", i.FizzBuzz(), i, (i % 3) == 0, (i % 15) != 0));

                if (i != 0 && (i % 15) != 0)
                    Assert.True(i.FizzBuzz() != "FizzBuzz",
                        String.Format("Expected = {0}, Actual = FizzBuzz", i.FizzBuzz()));
            }
        }

        [Fact]
        public void ZeroTest()
        {
            Assert.Equal("0", 0.FizzBuzz());
        }
    }
}
