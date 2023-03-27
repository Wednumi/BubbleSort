using BubbleSort;

namespace Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_Sorts_Ints()
        {
            var list = new List<int>() { 2, 5, 1, 8 };
            var expected = new List<int>() { 1, 2, 5, 8 };

            list.BubbleSort();

            Assert.Equal(expected, list);
        }

        [Fact]
        public void BubbleSort_Sorts_Doubles()
        {
            var list = new List<double>() { 2.2, 2.1, -7.1, 8 };
            var expected = new List<double>() { -7.1, 2.1, 2.2, 8 };

            list.BubbleSort();

            Assert.Equal(expected, list);
        }
    }
}