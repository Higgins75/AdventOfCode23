using System;
using System.Text.RegularExpressions;
class Operations
{
    public List<int> GenerateNumberList(string input)
    {
        List<int> NumberList = new List<int>();
        string pattern = @"-?\b\d+\b";
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

    public List<int> extrapolate(List<int> input)
    {
        List<int> output = new List<int>();

        for (int i = 0; i < input.Count - 1; i++)
        {
            output.Add(input[i + 1] - input [i]);
        }

        return output;
    }

    public bool CheckAllZeros(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            if (number != 0)
            {
                return false; // Return false if any value is not equal to 0
            }
        }

        return true; // If all values are equal to 0, return true
    }
}
