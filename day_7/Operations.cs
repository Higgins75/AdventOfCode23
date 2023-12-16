class Operations
{
    //need to replace Dictionary with some kind of Tuple for sorting
    public List<(char, int)> GetMostFrequentCharacters(string input)
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

        char[] CardValueArr = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'];
        
        List<(char, int)> mostFrequent = charCounts.OrderByDescending(pair => pair.Value)
                                         .ThenByDescending(pair => Array.IndexOf(CardValueArr, pair.Key))
                                         .Select(pair => (pair.Key, pair.Value))
                                         .Take(numberOfResults)
                                         .ToList();

        return mostFrequent;
    }

    public int getBaseHandValue(string input)
    {
        List<(char, int)> mostFrequent = GetMostFrequentCharacters(input);

        var firstPosition = mostFrequent.FirstOrDefault();
        int value = firstPosition.Item2;

        if (value >= 3)
        {
            value += 1;
        }

        if (value == 2 && mostFrequent.Count >= 2)
        {
            if (mostFrequent.ElementAt(1).Item2 == 2)
            {
                value += 1;
            }
        }

        if (value >= 5)
        {
            value += 1;
        }

        if (value == 4 && mostFrequent.Count >= 2)
        {
            if (mostFrequent.ElementAt(1).Item2 == 2)
            {
                value += 1;
            }
        }


        return value;
    }

    public int getHighestCard(string input, int i)
    {
        
        char toCheck = input[i];
        char[] CardValueArr = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'];
        int value = Array.IndexOf(CardValueArr, toCheck);

        return value;
    }

}