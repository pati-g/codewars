using CodeWars;

namespace CodeWarsTests
{
    public class MergeArraysTest
    {
        [Fact]
        public void MergeResultCorrectForSameLengthArrays()
        {
            string[] expected = new string[] { "a", "1", "b", "2", "c", "3", "d", "4", "e", "5", "f", "6" };
            string[] actual = MergeArrays.Merge(new string[] { "a", "b", "c", "d", "e", "f" }, new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void MergeResultCorrectForDifferentLengthArrays()
        {
            string[] expected = new string[] { "a", "1", "b", "2", "c", "3", "d", "4", "e", "f" };
            string[] actual = MergeArrays.Merge(new string[] { "a", "b", "c", "d", "e", "f" }, new int[] { 1, 2, 3, 4 });
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void MergeResultCorrectIfSecondArrayIsEmpty()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6" };
            string[] actual = MergeArrays.Merge(new string[] { }, new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void MergeResultCorrectIfOneArrayIsEmpty()
        {
            string[] expected = new string[] { "a", "b", "c", "d", "e", "f" };
            string[] actual = MergeArrays.Merge(new string[] { "a", "b", "c", "d", "e", "f" }, new int[] { });
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void MergeResultCorrectIfBothArraysAreEmpty()
        {
            string[] expected = new string[] { };
            string[] actual = MergeArrays.Merge(new string[] { }, new int[] { });
            Assert.Equivalent(expected, actual);
        }
    }
}
