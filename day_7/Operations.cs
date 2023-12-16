class Operations
{
    public Dictionary<char, int> GetMostFrequentCharacters(string input)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

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

        return charCounts;
    }

    public int getBaseHandValue(string input)
    {
        Dictionary<char, int> charCounts = GetMostFrequentCharacters(input);
        char[] CardValueArr = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'];
        
        var mostFrequent = charCounts.OrderByDescending(pair => pair.Value)
                                         .ThenBy(pair => Array.IndexOf(CardValueArr, pair.Key))
                                         .ToDictionary(pair => pair.Key, pair => pair.Value);

        var firstPosition = mostFrequent.FirstOrDefault();
        int value = firstPosition.Value;

        if (value >= 3)
        {
            value += 1;
        }

        if (value == 2 && mostFrequent.Count >= 2)
        {
            if (mostFrequent.ElementAt(1).Value == 2)
            {
                value += 1;
            }
        }

        return value;
    }
}