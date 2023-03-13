namespace CodeWars
{
    internal class LinkedListKata<T> where T : IComparable<T>
    {
        public static void SortedInsert(LinkedList<T> preSortedList, T element)
        {
            preSortedList.AddBefore(preSortedList.Find(preSortedList.Where(el => el.CompareTo(element) > 0).First()), new LinkedListNode<T>(element));
        }
    }
}