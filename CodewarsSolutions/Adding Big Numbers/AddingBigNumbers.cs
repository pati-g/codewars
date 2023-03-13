namespace CodeWars;

public class BigNumbers
{
    // Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.
    public static string Add(string a, string b)
    {
        int len = Math.Max(a.Length, b.Length) + 1;
        char[] sumArr = new char[len];
        char[] arrayA = a.PadLeft(len, '0').ToCharArray();
        char[] arrayB = b.PadLeft(len, '0').ToCharArray();
        byte transfer = 0;
        int index = len - 1;

        while (index >= 0)
        {
            int sum = arrayA[index] - 48 + arrayB[index] - 48 + transfer;
            transfer = (byte)Convert.ToInt32(sum > 9);
            sumArr[index] = (sum % 10).ToString()[0];
            index--;
        }
        return sumArr[0] == '0' ? new string(sumArr, 1, sumArr.Length - 1) : new string(sumArr);
    }
}
