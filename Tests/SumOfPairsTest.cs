using CodeWars;

namespace CodeWarsTests
{
    public class SumOfPairsTest
    {
        [Fact]
        public void ReturnsPairCorrectly()
        {
            int sum = 6;
            var numbers = new List<int>() { 4, 3, 2, 3, 4 };
            Assert.Equal((4, 2), SumOfPairs.SumPairs(sum, numbers));
        }

        [Fact]
        public void ReturnsPairWithLowestSecondIndex()
        {
            int sum = 10;
            var numbers = new List<int>() { 10, 5, 2, 3, 7, 5 };
            Assert.Equal((3, 7), SumOfPairs.SumPairs(sum, numbers));
        }

        [Fact]
        public void ReturnsMinusOneWhenNoPairs()
        {
            int sum = 2;
            var numbers = new List<int>() { 0, 0, -2, 3 };
            Assert.Equal((-1, -1), SumOfPairs.SumPairs(sum, numbers));
        }
    }
}
