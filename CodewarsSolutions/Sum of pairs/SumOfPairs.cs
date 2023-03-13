namespace CodeWars
{
    internal class SumOfPairs
    {
        public static (int, int) SumPairs(int sumValue, List<int> numbers)
        {
            (int, int) currentPair = (-1, -1);
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (j >= currentPair.Item2 && currentPair.Item2 != -1)
                        break;
                    if (numbers[i] + numbers[j] == sumValue)
                    {
                        currentPair = (i, j);
                    }
                }
            }
            return currentPair == (-1, -1) ? currentPair : (numbers[currentPair.Item1], numbers[currentPair.Item2]);
        }
    }
}
