using CodeWars;

namespace CodeWarsTests
{
    public class LinkedListKataTest
    {
        [Fact]
        public void AddsToListInCorrectOrder()
        {
            int[] arr = new int[] { 1, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            var list = new LinkedList<int>(arr);
            LinkedListKata<int>.SortedInsert(list, 2);
            Assert.Equal(new LinkedList<int>(arr2), list);
        }

        [Fact]
        public void AddsToListInCorrectOrder2()
        {
            int[] arr = new int[] { 1, 3, 7, 10 };
            int[] arr2 = new int[] { 1, 3, 5, 7, 10 };
            var list = new LinkedList<int>(arr);
            LinkedListKata<int>.SortedInsert(list, 5);
            Assert.Equal(new LinkedList<int>(arr2), list);
        }

        [Fact]
        public void WorksForStrings()
        {
            string[] arr = new string[] { "1", "3", "7", "10" };
            string[] arr2 = new string[] { "1", "3", "5", "7", "10" };
            var list = new LinkedList<string>(arr);
            LinkedListKata<string>.SortedInsert(list, "5");
            Assert.Equal(new LinkedList<string>(arr2), list);
        }

        [Fact]
        public void WorksForWords()
        {
            string[] arr = new string[] { "ala", "bela", "fela", "zela" };
            string[] arr2 = new string[] { "ala", "bela", "fela", "komfa", "zela" };
            var list = new LinkedList<string>(arr);
            LinkedListKata<string>.SortedInsert(list, "komfa");
            Assert.Equal(new LinkedList<string>(arr2), list);
        }
    }
}
