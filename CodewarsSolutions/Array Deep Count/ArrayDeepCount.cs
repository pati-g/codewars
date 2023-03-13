namespace CodeWars;

public class ArrayDeepCount
{
    // You are given an array. Complete the function that returns the number of ALL elements within an array, including any nested arrays.
    public static int DeepCount(object a)
    {
        int counter = 0;
        return CountHelper(a, counter);
    }
    private static int CountHelper(object a, int counter)
    {
        if (a.GetType().IsArray)
        {
            object[] array = (object[])a;
            foreach (object obj in array)
            {
                if (obj.GetType().IsArray)
                {
                    counter = CountHelper(obj, counter);
                }
                counter++;
            }
        }
        return counter;
    }
}
