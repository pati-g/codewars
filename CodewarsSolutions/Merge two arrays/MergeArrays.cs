namespace CodeWars
{
    internal class MergeArrays
    {
        public static string[] Merge(string[] array1, int[] array2)
        {
            string[] result = new string[array1.Length + array2.Length];
            int index = 0;
            for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (i < array1.Length)
                {
                    result[index++] = array1[i];
                }
                if (i < array2.Length)
                {
                    result[index++] = array2[i].ToString();
                }
            }
            return result;
        }
    }
}
