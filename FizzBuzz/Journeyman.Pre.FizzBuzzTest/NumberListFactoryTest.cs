using Journeyman.Pre.FizzBuzz;
using System;
using System.Linq;
using Xunit;

namespace Journeyman.Pre.FizzBuzzTest
{
    public class NumberListFactoryTest
    {
        [Fact]
        public void NumberListPopulateTest_CreateNumberList_LowerBoundGreaterThanUpperBound()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    NumberListFactory.CreateNumberList(1, 0, 1);
                }
            );
        }

        [Fact]
        public void NumberListPopulateTest_CreateNumberList_InvalidIncrement()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    NumberListFactory.CreateNumberList(0, 1, 0);
                }
            );
        }

        [Fact]
        public void NumberListPopulateTest_CreateNumberList_1To100ListCreatedSuccessfully()
        {
            var numberList = NumberListFactory.CreateNumberList(1, 100, 1);

            var count = numberList.Count;
            var max = (from number in numberList
                       select number).Max();
            var min = (from number in numberList
                       select number).Min();

            Assert.Equal(100, count);
            Assert.Equal(1, min);
            Assert.Equal(100, max);
        }
    }
}
