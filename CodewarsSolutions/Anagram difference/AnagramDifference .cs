internal class AnagramDifference
{
    // Calculate how many letters have to be removed from each of 2 words to make them anagrams
    public static int CalculateAnagramDifference(string word1, string word2)
    {
        var dictionary = new Dictionary<char, int>();
        foreach (char c in word1)
        {
            if (dictionary.ContainsKey(c))
                dictionary[c]++;
            else
                dictionary.Add(c, 1);
        }

        foreach (var c in word2)
        {
            if (dictionary.ContainsKey(c))
            {
                dictionary[c]--;
                if (dictionary[c] == 0)
                {
                    dictionary.Remove(c);
                }
            }
            else
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }
        }
        int count = dictionary.Values.Sum();
        return count;
    }
}