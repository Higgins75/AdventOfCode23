class Operations
{
    public List<(char Character, int Count)> GetMostFrequentCharacters(string input)
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

        var mostFrequent = charCounts.OrderByDescending(kv => kv.Value).Take(numberOfResults).ToList();

        return mostFrequent.Select(kv => (kv.Key, kv.Value)).ToList();
    }
}