
namespace CodeWarsTests
{
    public class AnagramDifferenceTest
    {
        [Fact]
        public void CountsDifferentLettersCorrectly()
        {
            string word1 = "John Smith";
            string word2 = "Mary Smith";
            Assert.Equal(8, AnagramDifference.CalculateAnagramDifference(word1, word2));
        }

        [Fact]
        public void WhenTwoStringsWithSameLettersThen0()
        {
            string word1 = "John Smith";
            string word2 = "Smith John";
            string word3 = "hhiJmn oSt";
            Assert.Equal(0, AnagramDifference.CalculateAnagramDifference(word1, word2));
            Assert.Equal(0, AnagramDifference.CalculateAnagramDifference(word3, word2));
        }

        [Fact]
        public void WhenTwoEmptyStringsThen0()
        {
            string word1 = "";
            string word2 = "";
            Assert.Equal(0, AnagramDifference.CalculateAnagramDifference(word1, word2));
        }
    }
}