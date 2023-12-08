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

    public List<int> GenerateNumberList(string card)
    {
        List<int> NumberList = new List<int>();
        for (int i = 0; i < card.Length; i++)
        {
            if (isNum(card[i]))
            {
                NumberList.Add(getASCIIValue(getDigit(card, i++)) * 10 + getASCIIValue(getDigit(card, i)));
                i++;
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