class Operations
{
    public int GetMostFrequentCharacters(string input)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        char[] CardValueArr = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'];
        int numberOfResults = 2;
        foreach (char c in input)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        var mostFrequent = charCounts.OrderByDescending(kv => kv.Value).FirstOrDefault();

        int value = Array.IndexOf(CardValueArr, mostFrequent.Key) * mostFrequent.Value;

        return value;
    }
}