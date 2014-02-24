
using System;
using Xunit;

namespace Journeyman.Pre.CollectionsTest
{
    public class ListTest
    {
        [Fact]
        public void List_InitialiseWithRandomIntegerArrayTest()
        {
            var random = new Random();
            var arraySize = random.Next(20, 200);
            var items = new int[arraySize];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = random.Next();
            }

            var list = new Collections.List<int>(items);
            Assert.Equal(items.Length, list.Count);
            Assert.Equal((int)Math.Round(arraySize * 1.2m), list.Capacity);

            for (int i = 0; i < items.Length; i++)
            {
                Assert.Equal(items[i], list[i]);
            }
        }

        [Fact]
        public void List_InitialiseDefaultListTest()
        {
            var list = new Collections.List<int>();
            Assert.Equal(0, list.Count);
            Assert.Equal((int)Math.Round(4 * 1.2m), list.Capacity);
        }

        [Fact]
        public void List_IntitialiseWithNullArrayTest()
        {
            Assert.Throws<ArgumentNullException>(
                delegate
                {
                    new Collections.List<int>(null);
                }
            );
        }
    }
}
