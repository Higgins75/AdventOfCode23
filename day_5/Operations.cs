using System.Text.RegularExpressions;

class Operations
{
    public List<int> GenerateNumberList(string input)
    {
        List<int> NumberList = new List<int>();
        string pattern = @"\b\d+\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            if (int.TryParse(match.Value, out int number))
            {
                NumberList.Add(number);
            }
        }
        return NumberList;
    }

    public Map GenerateMap(string input)
    {
        Map mappedPosition;

        List<int> mapNumbers = GenerateNumberList(input);

        mappedPosition.destination_range = mapNumbers[0];
        mappedPosition.source_range = mapNumbers[1];
        mappedPosition.range_length = mapNumbers[2];

        return mappedPosition;
    }
}