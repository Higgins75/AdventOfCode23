using System.Text.RegularExpressions;

class Operations
{
    public string[] StringCleaner(string toClean)
    {
        string[] cleanedString = toClean.Split(':');
        string[] stringArray = cleanedString[1].Split('|');
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i].Trim();
        }
        return stringArray;
    }

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

    public bool isNum(char test)
    {
        int value = Convert.ToInt32(test);
        if (value > 47 && value < 58)
        {
            return true;
        }
        return false;
    }
    public int getASCIIValue(char test)
    {
        return Convert.ToInt32(test - 48);
    }

    public char getDigit(string card, int index)
    {
    if (index >= 0 && index < card.Length) 
    {
        return card[index];
    }
    return '\0';
    }
    
}