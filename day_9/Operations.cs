using System;
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
}
